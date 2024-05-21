using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : TextContent
{
    public string ID { get; set; }
    public string ChoiceText { get; set; }
    public List<Option> Options { get; set; } = new List<Option>();
    public string DiagType { get; set; } 


    public Choice(string iD, string choiceText, string diagType)
    {
        ID = iD;
        ChoiceText = choiceText;
        DiagType = diagType;
    }

    public void addOption(int id, string option, int karma_value)
    {
        Options.Add(new Option(id, option, karma_value));
    }

}
