const ncp = require('ncp').ncp;
const fs = require('fs');
const path = './../../Bars..Mobile/ClientApp';
if (fs.existsSync(path)) {
    ncp(path, './', function(err) {
        if (err) {
            return console.error(err);
        }
        console.log('Кастомная часть успешно синхронизирована!');
    });
}