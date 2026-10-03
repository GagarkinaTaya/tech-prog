namespace lab_2;

public class MobileHouse : Building, Moveable
{
    public MobileHouse(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
    {
    }
    
    public void Move(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}