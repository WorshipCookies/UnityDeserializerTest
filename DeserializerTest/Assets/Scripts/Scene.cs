using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene
{

    public int SceneID { get; set; }

    public Scene(int SceneID)
    {
        this.SceneID = SceneID;
    }
    
    public List<TextContent> Dialogues { get; set; } = new List<TextContent>();

    public void enqueueDiag(TextContent text)
    {
        this.Dialogues.Add(text);
    }

}
