abstract class Географічний_обєкт
{
    public int x;
    public int y;
    public string назва;
    public string опис;
    public virtual void отримати_інформацію()
    {
        
    }
}

class Річка : Географічний_обєкт
{
    public int швидкість_течії;
    public int загальна_довжина;
    
}

class Гора : Географічний_обєкт
{
    public int найвища_точка;
}