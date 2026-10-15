public abstract class ScoreSessionATD
{
    // команды

    // предусловие: matched_count >= 3
    // постусловие: к current_score добавлены очки
    public abstract void register_match(int matched_count);

    // постусловие: combo_multiplier увеличен на 1
    public abstract void advance_combo();

    // постусловие: combo_multiplier сброшен в 1    
    public abstract void reset_combo();

    // постусловие: current_score = 0, combo_multiplier = 1
    public abstract void reset_session();

    // запросы

    public abstract int current_score();
    public abstract int combo_multiplier();
}
