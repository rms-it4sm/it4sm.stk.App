/**
 * Информация о действии во всплывающем окне
 */
export class PopoverAction {
    /**
     * Имя действия
     */
    action: string;

    /**
     * Отображаемое наименование
     */
    display: string;

    constructor(action: string, display: string) {
        this.action = action;
        this.display = display;
    }
}