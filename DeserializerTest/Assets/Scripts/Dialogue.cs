using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Dialogue : TextContent
{
    // Start is called before the first frame update
    public string DiagType { get; set; }

    public int ID { get; set; } = 0;

    public List<Speech> text { get; set; } = new List<Speech>();

    public List<Consequence> consequences { get; set; } = new List<Consequence>();

    public void addSpeech(string dialog, Character c)
    {
        text.Add(new Speech(c, dialog));
    }

    public void addConsequences(Consequence consequence)
    {
        consequences.Add(consequence);
    }

    public string checkRef(string dialog)
    {
        // Check Ref in Text
        return "";
    }


}
