using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEditor.SearchService;
using System.IO;
using Newtonsoft.Json.Linq;


public class TestJSON_Script : MonoBehaviour
{

    private string path = "Assets/JSONObjects/Scene1.json";

    // Start is called before the first frame update
    void Start()
    {


        var setting = new JsonSerializerSettings();
        setting.Converters.Add(new SceneConverter());

        Scene scene = JsonConvert.DeserializeObject<Scene>(File.ReadAllText(path), setting);
        
        Debug.Log("I AM Here!!");


    }

}
