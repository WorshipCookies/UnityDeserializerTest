using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

    public string Name { get; set; }
    public string ID { get; set; }

    public Character(string name, string ID)
    {
        this.ID = ID;
        this.Name = name;
    }


}
