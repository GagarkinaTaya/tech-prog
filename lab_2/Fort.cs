namespace lab_2;

public class Fort : Building, Attacker
{
    public Fort(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
    {
    }
    
    public void Attack(Unit unit)
    {
        unit.ReceiveDamage(35);
    }
}