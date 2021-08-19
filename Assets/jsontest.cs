using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    public bool Note1, Note2,Note4;
    public Data(bool note1, bool note2, bool note4)
    {
        Note1 = note1;
        Note2 = note2;
        Note4 = note4;
    }
    public void printDate()
    {
        Debug.Log("note1 : " + Note1);
        Debug.Log("note2 : " + Note2);
        Debug.Log("note4 : " + Note4);
    }
}

public class jsontest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Data data = new Data(false, false, false);
        

        string str = JsonUtility.ToJson(data);

        Debug.Log("ToJson" + str);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get_note1()
    {

    }

    public void get_note2()
    {

    }

    public void get_note4()//얻은 쪽지 저장
    {

    }

    public void click_inventory()//인벤토리에 로드
    {

    }

}
