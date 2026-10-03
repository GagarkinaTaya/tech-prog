namespace lab_2;

public abstract class GameObject
{
    protected int id;
    protected string name;
    protected int x;
    protected int y;
    
    public GameObject(int id, string name, int x, int y)
    {
        this.id = id;
        this.name = name;
        this.x = x;
        this.y = y;
    }
    
    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
}