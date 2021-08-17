using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enternum : MonoBehaviour
{
    public GameObject notion;
    public Text answer;
    string input = null;

    // Start is called before the first frame update
    void Start()
    {
        answer.text = null;
    }

    // Update is called once per frame
    public void enter_0()
    {
        answer.text = answer.text + "0";
    }

    public void enter_1()
    {
        answer.text = answer.text + "1";
    }

    public void enter_2()
    {
        answer.text = answer.text + "2";
    }

    public void enter_3()
    {
        answer.text = answer.text + "3";
    }

    public void enter_4()
    {
        answer.text = answer.text + "4";
    }

    public void enter_5()
    {
        answer.text = answer.text + "5";
    }

    public void enter_6()
    {
        answer.text = answer.text + "6";
    }

    public void enter_7()
    {
        answer.text = answer.text + "7";

        if(answer.text == "01019872887")
        {
            notion.gameObject.SetActive(true);
        }
    }

    public void enter_8()
    {
        answer.text = answer.text + "8";
    }

    public void enter_9()
    {
        answer.text = answer.text + "9";
    }

    public void trash()
    {
        input = null;
        answer.text = input;
    }

    void Update() //알림창사라지게 하기
    {
        if (notion.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            notion.gameObject.SetActive(false); //펼쳐졌던 쪽지가 꺼짐
        }
    }
}
