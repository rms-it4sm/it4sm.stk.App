import { Routes } from '@angular/router';

/**
 * Системные роуты
 */
export const appRoutes: Routes = [
    {
        path: '',
        loadChildren: () => import('../pages/login/login.module').then(m => m.LoginPageModule)
    },
    {
        path: 'app',
        loadChildren: () => import('../pages/main/main.module').then(m => m.MainPageModule)
    }
];