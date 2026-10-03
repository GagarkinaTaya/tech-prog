namespace lab_2;

public abstract class Unit : GameObject
{
    protected float hp;
    
    public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
    {
        this.hp = hp;
    }

    public float GetHp()
    {
        return hp;
    }
    
    public bool IsAlive()
    {
        return hp > 0;
    }
    
    public void ReceiveDamage(float damage)
    {
        hp -= damage;
    }
}