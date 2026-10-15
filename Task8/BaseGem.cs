public abstract class BaseGemATD
{
    // команды

    // постусловие: фишка помечена как "участвующая в совпадении" (готова к удалению)
    public abstract void mark_for_match();

    // предусловие: фишка помечена (is_matched() == true)
    // постусловие: применен специфичный для типа фишки эффект на переданной доске
    public abstract void activate_effect(GridBoard board);

    // запросы
  
    // постусловие: возвращает целочисленный идентификатор цвета/типа
    public abstract int get_color_id();
    // постусловие: возвращает true, если фишка ожидает удаления
    public abstract bool is_matched();
}
