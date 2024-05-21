using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option
{
    // Start is called before the first frame update
    public int option_ID { get; set; }
    public string option_text { get; set; }
    public int karma_value { get; set; }

    public Option(int option_ID, string option_text, int karma_value)
    {
        this.option_ID = option_ID;
        this.option_text = option_text;
        this.karma_value = karma_value;
    }

}
