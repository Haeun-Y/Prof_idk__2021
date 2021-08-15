using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textscript : MonoBehaviour
{
    public Image al;
    public Image go;
    public Image it;
    public Image da;
    public Sprite after_al;
    public Sprite after_go;
    public Sprite after_it;
    public Sprite after_da;
    public Text answer;
    string input = null;
    int check_al =0;
    int check_go = 0;
    int check_it= 0;
    public GameObject getblock_algoitda;
    

    // Start is called before the first frame update
    void Start()
    {
        answer.text = null;
        input = null;
    }


    // Update is called once per frame
    public void sky()
    {
        input = input + ".";
        answer.text = input;
        
        
        if(input == "ㅣ." && check_al == 0)
        {
            al.sprite = after_al;//이미지 바뀜
            da.sprite = after_da;
            Invoke("trash", 1);//1초후 함수 a 호출
            check_al = 1;
        }
       
        
        if(check_al ==1 && check_go ==1 && check_it == 1)
        {
            getblock_algoitda.gameObject.SetActive(true);
        }

    }

    public void land()
    {
        input = input + "ㅡ";
        answer.text = input;


        if (input == ".ㅡ" && check_go == 0)
        {
            go.sprite = after_go;//이미지바뀜
            Invoke("trash", 1);//1초후 함수 o 호출
            check_go = 1;
        }

        if (check_al == 1 && check_go == 1 && check_it == 1)
        {
            getblock_algoitda.gameObject.SetActive(true);
        }

    }
    public void man()
    {
        input = input + "ㅣ";
        answer.text = input;


        if (input == "ㅣ" && check_it == 0)
        {
            it.sprite = after_it;//이미지바뀜
            Invoke("trash", 1);//1초후 함수 o 호출
            check_it = 1;
        }

        if (check_al == 1 && check_go == 1 && check_it == 1)
        {
            getblock_algoitda.gameObject.SetActive(true);
        }
    }

    public void trash()
    {
        input = null;
        answer.text = input;
    }
}
