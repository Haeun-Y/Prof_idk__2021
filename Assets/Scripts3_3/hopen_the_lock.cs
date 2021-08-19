using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hopen_the_lock : MonoBehaviour
{
    public Button btn_1,btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9, btn_0, btn_trash, btn_okay_lock, btn_open_lock;
    public Text txt_num;
    public Text txt1, txt2, txt3, txt4, txt5;
    public GameObject pop_complete;
    // Start is called before the first frame update

    void Start()
    {
       
    }
    public void click_okay()
    {
        pop_complete.gameObject.SetActive(false);
        btn_open_lock.gameObject.SetActive(false);
    }

    public void click_open_lock()
    {
        btn_open_lock.gameObject.SetActive(false);
    }

    public void click_trash()
    {
        txt1.text = "";
        txt2.text = "";
        txt3.text = "";
        txt4.text = "";
        txt5.text = "";
        txt_num.text = "0";
       

    }

    //정답 : 07734

    public void click_1()
    {
        string str = txt_num.text;
        int tmp;
        switch(str)
        {
            case "0":
                txt1.text = "1";
               
                break;
            case "1":
                txt2.text = "1";
                
                break;

            case "2":
                txt3.text = "1";
               
                break;
            case "3":
                txt4.text = "1";
                
                break;
            case "4":
                txt5.text = "1";
               
                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }

    public void click_2()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "2";

                break;
            case "1":
                txt2.text = "2";

                break;

            case "2":
                txt3.text = "2";

                break;
            case "3":
                txt4.text = "3";

                break;
            case "4":
                txt5.text = "4";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
    public void click_3()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "3";

                break;
            case "1":
                txt2.text = "3";

                break;

            case "2":
                txt3.text = "3";

                break;
            case "3":
                txt4.text = "3";

                break;
            case "4":
                txt5.text = "3";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }

    public void click_4()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "4";

                break;
            case "1":
                txt2.text = "4";

                break;

            case "2":
                txt3.text = "4";

                break;
            case "3":
                txt4.text = "4";

                break;
            case "4":
                txt5.text = "4";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
   

    if(tmp == 5 && txt1.text == "0" && txt2.text == "7" && txt3.text == "7" && txt4.text == "3" && txt5.text == "4")
    {
        pop_complete.gameObject.SetActive(true);
    }

}

    public void click_5()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "5";

                break;
            case "1":
                txt2.text = "5";

                break;

            case "2":
                txt3.text = "5";

                break;
            case "3":
                txt4.text = "5";

                break;
            case "4":
                txt5.text = "5";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
    public void click_6()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "6";

                break;
            case "1":
                txt2.text = "6";

                break;

            case "2":
                txt3.text = "6";

                break;
            case "3":
                txt4.text = "6";

                break;
            case "4":
                txt5.text = "6";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
    public void click_7()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "7";

                break;
            case "1":
                txt2.text = "7";

                break;

            case "2":
                txt3.text = "7";

                break;
            case "3":
                txt4.text = "7";

                break;
            case "4":
                txt5.text = "7";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }


    public void click_8()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "8";

                break;
            case "1":
                txt2.text = "8";

                break;

            case "2":
                txt3.text = "8";

                break;
            case "3":
                txt4.text = "8";

                break;
            case "4":
                txt5.text = "8";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
    public void click_9()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "9";

                break;
            case "1":
                txt2.text = "9";

                break;

            case "2":
                txt3.text = "9";

                break;
            case "3":
                txt4.text = "9";

                break;
            case "4":
                txt5.text = "9";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
    public void click_0()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                txt1.text = "0";

                break;
            case "1":
                txt2.text = "0";

                break;

            case "2":
                txt3.text = "0";

                break;
            case "3":
                txt4.text = "0";

                break;
            case "4":
                txt5.text = "0";

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
}
