/**
 * Информация о сообщении
 */
export class EventBusMessage {
    /**
     * Ключ
     */
    key: string;

    /**
     * Значение
     */
    value: any;

    constructor(key: string, value?: any) {
        this.key = key;
        this.value = value;
    }
}