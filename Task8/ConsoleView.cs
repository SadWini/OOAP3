public abstract class ConsoleViewATD
{
    // статусы
    public const int READ_OK = 0;
    public const int READ_ERR = 1; 
    public const int READ_QUIT = 2;
    public const int READ_NIL = -1;

    // команды

    // предусловие: board и session не равны null
    // постусловие: визуальное представление сетки и текущего счета выведено в консоль
    public abstract void render_frame(GridBoard board, ScoreSession session);

    // предусловие: message не равно null
    // постусловие: текстовое уведомление выведено в консоль
    public abstract void render_message(string message);

    // команды

    // постусловие: ввод пользователя считан из консоли. 
    //              Если формат корректен, они сохранены внутренне (READ_OK).
    //              Если формат неверен, статус = READ_ERR.
    //              Если введена команда выхода, статус = READ_QUIT.
    public abstract void read_input();


    // запросы

    // предусловие: последний вызов read_input() завершился со статусом READ_OK
    // постусловие: возвращает распарсенную координату первой выбранной фишки
    public abstract CellCoordinate get_source_coordinate();

    // предусловие: последний вызов read_input() завершился со статусом READ_OK
    // постусловие: возвращает распарсенную координату второй выбранной фишки
    public abstract CellCoordinate get_target_coordinate();


    // запросы статусов
    
    public abstract int get_read_status();
}
