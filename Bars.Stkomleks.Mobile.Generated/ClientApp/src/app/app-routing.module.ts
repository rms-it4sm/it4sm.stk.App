import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { appRoutes } from './routing/app-routes';
import { appGeneratedRoutes } from './routing/app-routes.generated';

const routes: Routes = [
  ...appRoutes,
  ...appGeneratedRoutes
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}