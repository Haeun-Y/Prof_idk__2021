using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;




public class json_block_cyber : MonoBehaviour
{
    public GameObject algoitda, vector, prof, na, mola, exam;
    public void save(Data_block data)
    {
        File.WriteAllText(Application.dataPath + "/Block.json", JsonUtility.ToJson(data));
    }

    public Data_block load()
    {
        if (File.Exists(Application.dataPath + "/Block.json"))
        {
            string str2 = File.ReadAllText(Application.dataPath + "/Block.json");


            Data_block data4 = JsonUtility.FromJson<Data_block>(str2);
            return data4;
        }
        else
        {
            Data_block data = new Data_block();
            return data;
        }

    }
    // Start is called before the first frame update 
    void Start()
    {

        Data_block data3 = new Data_block();
        data3 = load();
    }

    // Update is called once per frame 
    void Update()
    {
        Data_block data = load();

        algoitda.gameObject.SetActive(data.block_algoitda);

        vector.gameObject.SetActive(data.block_vector);

        na.gameObject.SetActive(data.block_na);
        mola.gameObject.SetActive(data.block_mola);
        prof.gameObject.SetActive(data.block_prof2);
        exam.gameObject.SetActive(data.block_exam);

    }

    public void click()
    {

        Data_block data = load();
        data.printData_block();
        data.block_algoitda = true;
        data.printData_block();
        save(data);

    }

    public void click2()
    {

        Data_block data = load();
        data.printData_block();
        data.block_vector = true;
        data.printData_block();
        save(data);

    }


}
