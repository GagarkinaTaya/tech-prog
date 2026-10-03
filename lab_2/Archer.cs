namespace lab_2;

public class Archer : Unit, Attacker, Moveable
{
    public Archer(int id, string name, int x, int y, float hp) : base(id, name, x, y, hp)
    {
    } 
    
    public void Attack(Unit unit)
    {
        unit.ReceiveDamage(15);
    }
    
    public void Move(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}