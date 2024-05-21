using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Speech
{
    public Character character { get; set; }
    public string text { get; set; }


    public Speech(Character character, string text)
    {
        this.character = character;
        this.text = text;
    }
}
