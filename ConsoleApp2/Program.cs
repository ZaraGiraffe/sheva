interface Географічний_обєкт
{
    int x {get; set;}
    int y {get; set;}
    string назва {get; set;}
    string опис {get; set;}
    virtual void отримати_інформацію()
    {
           
    }
}

class Річка : Географічний_обєкт
{
    public int швидкість_течії;
    public int загальна_довжина;
    public int _x;
    public int _y;
    public string _назва;
    public string _опис;
    public int x
    {
        get => _x; 
        set => _x = value; 
    }
    public int y
    {
        get => _y;
        set => _y = value;
    }
    public string назва
    {
        get => _назва;
        set => _назва = value;
    }
    
    public string опис
    {
        get => _опис; 
        set => _опис = value;
    }
}

class Гора : Географічний_обєкт
{
    private int найвища_точка;
    public int _x;
    public int _y;
    public string _назва;
    public string _опис;
    public int x
    {
        get => _x; 
        set => _x = value; 
    }
    public int y
    {
        get => _y;
        set => _y = value;
    }
    public string назва
    {
        get => _назва;
        set => _назва = value;
    }
    
    public string опис
    {
        get => _опис; 
        set => _опис = value;
    }

}

class Program
{
    static void Main()
    {
        
    }
}
