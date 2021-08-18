using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_desk : MonoBehaviour
{
    public Text txt_now, desk_tutorial_txt;
    public GameObject panel, tutorial1;
    //tutorial 종료 후에는 panel 0으로 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(txt_now.text == "1")
        {
            desk_tutorial_txt.text = "…그래도 오픈북 시험이니까 할 만할 수도 있지 않을까?";
        }

        if(txt_now.text == "2")
        {
            desk_tutorial_txt.text = "교수님: 자, 이제 시험 시작하시면 됩니다.";
        }

        if (txt_now.text == "3")
        {
            desk_tutorial_txt.text = "일단 빨리 문제부터 북 버튼을 클릭해서확인하자!";
        }

        if (txt_now.text == "4")
        {
            panel.gameObject.SetActive(false);
            tutorial1.gameObject.SetActive(true);
        }

    }

    public void click_btn()
    {
        string str = txt_now.text;
        str = (int.Parse(str) + 1).ToString();
        txt_now.text = str;

    }
}
