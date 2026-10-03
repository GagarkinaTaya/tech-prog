namespace lab_2;

public abstract class Building : GameObject
{
    protected bool built;
    
    public Building(int id, string name, int x, int y, bool built) : base(id, name, x, y)
    {
        this.built = built;
    }

    public bool IsBuilt()
    {
        return built;
    }
}