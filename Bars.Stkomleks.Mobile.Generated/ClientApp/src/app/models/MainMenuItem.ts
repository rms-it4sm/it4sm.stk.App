/**
 * Пункт главного меню
 */
export class MainMenuItem {
    /**
     * Наименование
     */
    name: string;

    /**
     * Иконка
     */
    icon: string;

    /**
     * Роут
     */
    route: string;

    /**
     * Отображать на главной странице
     */
    visibleOnMainPage: boolean;

    constructor(name: string, icon: string, route: string, visibleOnMainPage?: boolean){
        this.name = name;
        this.icon = icon;
        this.route = route;
        this.visibleOnMainPage = visibleOnMainPage;
    }
}