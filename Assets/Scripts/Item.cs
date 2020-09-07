using UnityEngine;

public class Item
{
    public string name;
    public string desc;
    public int amount;
    //public Sprite sprite;

    public Item(string name, string desc)
    {
        this.name = name;
        this.desc = desc;
        this.amount = 0;
        //this.sprite = (Sprite)Resources.Load("fire");
    }
    
    public override string ToString()
    {
        return name + ", " + desc + ", " + amount;
    }
}
