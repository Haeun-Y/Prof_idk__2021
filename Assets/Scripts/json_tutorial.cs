/*using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data_tutorial
{
    public bool desk;
    public bool cyber;
    public bool majorbook;

}

public class json_tutorial : MonoBehaviour
{
    public GameObject txt_desk, txt_cyber, txt_majorbook ;
    public void save(Data_tutorial data)
    {
        File.WriteAllText(Application.dataPath + "/Tutorial.json", JsonUtility.ToJson(data));
    }

    public Data_tutorial load()
    {
        if (File.Exists(Application.dataPath + "/Tutorial.json"))
        {
            string str2 = File.ReadAllText(Application.dataPath + "/Tutorial.json");


            Data_tutorial data4 = JsonUtility.FromJson<Data_tutorial>(str2);
            return data4;
        }
        else
        {
            Data_tutorial data = new Data_tutorial();
            return data;
        }

    }
    // Start is called before the first frame update 
    void Start()
    {

        Data_tutorial data3 = new Data_tutorial();
        data3 = load();
    }

    // Update is called once per frame 
    void Update()
    {
        Data_tutorial data = load();

        if(g)

        save(data);

    }

   
}
*/