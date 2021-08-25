/**
 * Информация о пользователе
 */
export class UserInfo {
    /**
     * Идентификатор
     */
    id: number;

    /**
     * Имя
     */
    name: string;

    /**
     * JWT-Токен
     */
    token: string;

    /**
     * Base-64 изображение
     */
    image: string;

    constructor(id?: number, name?: string, token?: string) {
        this.id = id;
        this.name = name;
        this.token = token;
    }
}