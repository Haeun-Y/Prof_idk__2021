using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[System.Serializable]
public class Data_block
{
    public bool block_algoitda;
    public bool block_vector;
    public bool block_prof2;
    public bool block_na;
    public bool block_mola;
    public bool block_exam;

    public void printData_block()
    {
        Debug.Log("알고있다 : " + block_algoitda);
        Debug.Log("방향 : " + block_vector);
        Debug.Log("교수님 : " + block_prof2);

    }
}

public class json_block : MonoBehaviour
{
    public GameObject inven_block_algoitda, inven_block_vector, inven_block_prof, inven_block_na, inven_block_mola, inven_block_exam;
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
        inven_block_algoitda.gameObject.SetActive(data.block_algoitda);

        inven_block_vector.gameObject.SetActive(data.block_vector);

        inven_block_prof.gameObject.SetActive(data.block_prof2);

        inven_block_na.gameObject.SetActive(data.block_na);

        inven_block_mola.gameObject.SetActive(data.block_mola);

        inven_block_exam.gameObject.SetActive(data.block_exam);

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

    public void click_prof()
    {

        Data_block data = load();
        data.printData_block();
        data.block_prof2 = true;
        data.printData_block();
        save(data);

    }

    public void click4()
    {

        Data_block data = load();
        data.printData_block();
        data.block_na = true;
        data.printData_block();
        save(data);

    }

    public void click5()
    {

        Data_block data = load();
        data.printData_block();
        data.block_mola = true;
        data.printData_block();
        save(data);

    }

    public void click6()
    {

        Data_block data = load();
        data.printData_block();
        data.block_exam = true;
        data.printData_block();
        save(data);

    }

}
