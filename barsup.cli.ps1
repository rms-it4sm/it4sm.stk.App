[CmdletBinding()]
Param(
    [Parameter(Position=0,Mandatory=$false,ValueFromRemainingArguments=$true)]
    [string[]]$BuildArguments
)

Write-Output "PowerShell $($PSVersionTable.PSEdition) version $($PSVersionTable.PSVersion)"

Set-StrictMode -Version 2.0; $ErrorActionPreference = "Stop"; $ConfirmPreference = "None"; trap { Write-Error $_ -ErrorAction Continue; exit 1 }
$PSScriptRoot = Split-Path $MyInvocation.MyCommand.Path -Parent

function ExecSafe([scriptblock] $cmd) {
    & $cmd
    if ($LASTEXITCODE) { exit $LASTEXITCODE }
}

function ExecReturn([scriptblock] $cmd) {
    & $cmd
    return $LASTEXITCODE; 
}

###########################################################################
# CONFIGURATION
###########################################################################

$DotNetVersion = "5.0"
$DotNetGlobalFile = "$PSScriptRoot\global.json"


# если файл global.json присутствует, то берем версию из него
if (Test-Path $DotNetGlobalFile) {
    # $DotNetGlobal = $(Get-Content $DotNetGlobalFile | Out-String | ConvertFrom-Json)
    # if ($DotNetGlobal.PSObject.Properties["sdk"] -and $DotNetGlobal.sdk.PSObject.Properties["version"]) {
    #     $DotNetVersion = $DotNetGlobal.sdk.version
    # }
}

$BuildProjectFile = "$PSScriptRoot\.cli\BarsUp.Cli.csproj"
$NuGetConfigFile = "$PSScriptRoot\.nuget\NuGet.config"

$TempDirectory = "$PSScriptRoot\.tmp"

# Использовать установленную версию sdk
$UseSystemDotNet = $false

function TryUseDotNetDirectory($Root, $Version){
    if ($Root -eq $null){
         return $null
    }

    $TempPath = Join-Path -Path $Root -ChildPath ".dotnet-versions"
    $TempPath = Join-Path -Path $TempPath -ChildPath $Version

    Write-Host "Check target directory: $TempPath"
    try {
        if (-Not (Test-Path $TempPath)){
            New-Item -ItemType Directory -Force -Path $TempPath | Out-Null
        }
        else {
            $TempFile = Join-Path -Path $TempPath -ChildPath "test-file";
            New-Item -ItemType File -Force -Path $TempFile | Out-Null
            Remove-Item -Force -Path $TempFile | Out-Null
        }       

        return $TempPath; 
    }
    catch{
        return $Null;
    }
}

if ($UseSystemDotNet -ne $true){
    
    # если НЕ используем установленную версию дотнета, то нужно скачать
    # SDK из интернетов и распаковать в целевой каталог
    
    # так как на одной машине может использоваться несколько версий, то проверяем,
    # имеем ли мы доступ до пользовательского каталога
    $DotNetDirectory = TryUseDotNetDirectory -Root "c:\" -Version $DotNetVersion;
    if ($DotNetDirectory -eq $null){
        $DotNetDirectory = TryUseDotNetDirectory -Root $env:UserProfile -Version $DotNetVersion;
    }
    if ($DotNetDirectory -eq $null){
        $DotNetDirectory = TryUseDotNetDirectory -Root $env:HOME -Version $DotNetVersion;
    }
    if ($DotNetDirectory -eq $null){
        $DotNetDirectory = TryUseDotNetDirectory -Root $TempDirectory -Version $DotNetVersion;
    }
    
    Write-Host "Target directory: $DotNetDirectory"
    
    # если в каталоге ничего нет или каталога не существует то качаем и распаковываем сдк
    $env:DOTNET_EXE = "$DotNetDirectory\dotnet.exe"

    if (-Not (Test-Path $env:DOTNET_EXE)){
        New-Item -ItemType Directory -Force -Path $DotNetDirectory | Out-Null

        # скрипт установки
        $DotNetInstallFile = "$PSScriptRoot\dotnet-install.ps1"    
        [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12    

        # устанавливаем            
        & $DotNetInstallFile -InstallDir $DotNetDirectory -Channel $DotNetVersion -NoPath     
    }                        
}
else {    
    # Check if any dotnet is installed
    if ($null -ne (Get-Command "dotnet" -ErrorAction SilentlyContinue)) {
        ExecSafe { & dotnet --info }
    }

    # используем системную версию если она установлена
    if ( $null -ne (Get-Command "dotnet" -ErrorAction SilentlyContinue) -and `    
        $(dotnet --version) -and $LASTEXITCODE -eq 0) {    
        Write-Output "Using system .Net"
        $env:DOTNET_EXE = (Get-Command "dotnet").Path 
    }
    else {
        Write-Output "System .Net not installed"
        exit
    }
}

$env:DOTNET_SKIP_FIRST_TIME_EXPERIENCE = 1
$env:DOTNET_CLI_TELEMETRY_OPTOUT = 1
$env:DOTNET_MULTILEVEL_LOOKUP = 0
$env:DOTNET_ROLL_FORWARD = "Major"

# Print environment variables
# WARNING: Make sure that secrets are actually scrambled in build log
# Get-Item -Path Env:* | Sort-Object -Property Name | ForEach-Object {"{0}={1}" -f $_.Name,$_.Value}


Write-Output "Microsoft (R) .NET Core SDK version $(& $env:DOTNET_EXE --version)"

#if (Test-Path env:NUKE_ENTERPRISE_PASSWORD) {
#    ExecSafe { & $env:DOTNET_EXE nuget add source $env:NUKE_ENTERPRISE_SOURCE --username $env:NUKE_ENTERPRISE_USERNAME --password $env:NUKE_ENTERPRISE_PASSWORD }
#}

$lec = ExecReturn { & $env:DOTNET_EXE restore $BuildProjectFile --use-lock-file --locked-mode --configfile $NuGetConfigFile /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary }
if ($lec){
    ExecSafe { & $env:DOTNET_EXE restore $BuildProjectFile --use-lock-file --locked-mode --force-evaluate --configfile $NuGetConfigFile /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary }
}

ExecSafe { & $env:DOTNET_EXE build $BuildProjectFile --no-restore --configfile $NuGetConfigFile /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary }
ExecSafe { & $env:DOTNET_EXE run --project $BuildProjectFile --no-build -- $BuildArguments }