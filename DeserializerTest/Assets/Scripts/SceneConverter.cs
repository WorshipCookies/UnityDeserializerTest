using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SceneConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(Scene);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        // Load Object 
        JObject jo = JObject.Load(reader);

        // Create the Scenne
        int scene_id = jo["SceneID"].ToObject<int>();
        Scene scene = new Scene(scene_id);

        // Check Dialogues and Cast them Accordingly
        foreach (var item in jo["Dialogues"]) 
        {
            string diag = item["DiagType"].ToObject<string>();
            if(diag == "Dialogue")
            {
                Dialogue d = item.ToObject<Dialogue>();
                scene.enqueueDiag(d);
            }
            else if (diag == "Choice")
            {
                Choice c = item.ToObject<Choice>();
                scene.enqueueDiag(c);
            }
        }
        return scene;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

}
