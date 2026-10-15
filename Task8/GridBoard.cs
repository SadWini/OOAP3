public abstract class GridBoardATD
{
    // Статусы
    public const int SWAP_OK = 0;
    public const int SWAP_ERR = 1; // Координаты невалидны или не являются соседними

    public const int GET_OK = 0;
    public const int GET_ERR = 1; // Выход за границы доски

    // Команды
  
    // предусловие: c1 и c2 находятся в пределах поля и являются соседними (по вертикали или горизонтали)
    // постусловие: объекты BaseGem по координатам c1 и c2 поменяны местами
    public abstract void swap(CellCoordinate c1, CellCoordinate c2);

    // предусловие: координаты находятся в пределах поля
    // постусловие: ячейка по заданным координатам становится пустой
    public abstract void remove_gem(CellCoordinate c);

    // постусловие: все "висящие" фишки смещены вниз в пустые ячейки. 
    // пустые ячейки остались только в верхних рядах доски.
    public abstract void apply_gravity();

    // постусловие: все пустые ячейки заполнены новыми объектами BaseGem
    public abstract void fill_empty_cells();

    // --- Запросы ---

    // предусловие: координата в пределах поля
    // постусловие: возвращает ссылку на BaseGem или null, если ячейка пуста
    public abstract BaseGem get_gem(CellCoordinate c);

    public abstract int width();
    public abstract int height();

    // --- Запросы статусов ---
    public abstract int get_swap_status();
    public abstract int get_get_status();
}
