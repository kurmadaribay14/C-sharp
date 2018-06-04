using System;
using System.Collections;

public class soldier
{
    public  string name;
    public int id;
    soldier[] soldiers;
    public soldier(string name,int id)
    {
        this.name = name;
        this.id = id;
    }

    
}
public class soldiercompany:IEnumerable
{
    private soldier[] soldiers;

    public soldiercompany()
    {
        soldiers = new soldier[]{new soldier("twan",34),new soldier("Varuna",24)};
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return soldiers.GetEnumerator();
    }
}