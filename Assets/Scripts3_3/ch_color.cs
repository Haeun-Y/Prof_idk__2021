using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ch_color : MonoBehaviour
{
    public Image first, second, third, fourth, fifth;
    public Button btn_okay_lock, btn_open_lock;
    public Text txt_num;
    public GameObject pop_complete;
    public Color bk, r, y, grn, bl, p;

    // Start is called before the first frame update

    void Start()
    {
        bk = new Color(0.2588235f, 0.254902f, 0.2588235f);
        r = new Color(0.7333333f, 0.2431373f, 0.2666667f);
        y = new Color(1f, 0.6666667f, 0.2235294f);
        grn = new Color(0.5647059f, 0.8509805f, 0.2901961f);
        bl = new Color(0.2588235f, 0.4705883f, 0.764706f);
        p = new Color(0.7411765f, 0.5411765f, 0.9058824f);

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
        first.gameObject.GetComponent<Image>().color = bk;
        second.gameObject.GetComponent<Image>().color = bk;
        third.gameObject.GetComponent<Image>().color = bk;
        fourth.gameObject.GetComponent<Image>().color = bk;
        fifth.gameObject.GetComponent<Image>().color = bk;

        txt_num.text = "0";


    }

    //정답 : 빨 파 보 초 노

    public void click_red()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                first.gameObject.GetComponent<Image>().color = r;

                break;
            case "1":
                second.gameObject.GetComponent<Image>().color = r;

                break;

            case "2":
                third.gameObject.GetComponent<Image>().color = r;

                break;
            case "3":
                fourth.gameObject.GetComponent<Image>().color = r;

                break;
            case "4":
                fifth.gameObject.GetComponent<Image>().color = r;

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }

    public void click_yellow()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                first.gameObject.GetComponent<Image>().color = y;

                break;
            case "1":
                second.gameObject.GetComponent<Image>().color = y;

                break;

            case "2":
                third.gameObject.GetComponent<Image>().color = y;

                break;
            case "3":
                fourth.gameObject.GetComponent<Image>().color = y;

                break;
            case "4":
                fifth.gameObject.GetComponent<Image>().color = y;

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
        //정답 : 빨 파 보 초 노

        if (tmp == 5 && first.gameObject.GetComponent<Image>().color == r && second.gameObject.GetComponent<Image>().color == bl && third.gameObject.GetComponent<Image>().color == p && fourth.gameObject.GetComponent<Image>().color == grn && fifth.gameObject.GetComponent<Image>().color == y)
        {
            pop_complete.gameObject.SetActive(true);
        }
    }
    public void click_grn()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                first.gameObject.GetComponent<Image>().color = grn;

                break;
            case "1":
                second.gameObject.GetComponent<Image>().color = grn;

                break;

            case "2":
                third.gameObject.GetComponent<Image>().color = grn;

                break;
            case "3":
                fourth.gameObject.GetComponent<Image>().color = grn;

                break;
            case "4":
                fifth.gameObject.GetComponent<Image>().color = grn;

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }

    public void click_bl()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                first.gameObject.GetComponent<Image>().color = bl;

                break;
            case "1":
                second.gameObject.GetComponent<Image>().color = bl;

                break;

            case "2":
                third.gameObject.GetComponent<Image>().color = bl;

                break;
            case "3":
                fourth.gameObject.GetComponent<Image>().color = bl;

                break;
            case "4":
                fifth.gameObject.GetComponent<Image>().color = bl;
                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();



    }

    public void click_5()
    {
        string str = txt_num.text;
        int tmp;
        switch (str)
        {
            case "0":
                first.gameObject.GetComponent<Image>().color = p;

                break;
            case "1":
                second.gameObject.GetComponent<Image>().color = p;

                break;

            case "2":
                third.gameObject.GetComponent<Image>().color = p;

                break;
            case "3":
                fourth.gameObject.GetComponent<Image>().color = p;

                break;
            case "4":
                fifth.gameObject.GetComponent<Image>().color = p;

                break;

            default:
                break;
        }
        tmp = int.Parse(str);
        tmp = tmp + 1;
        txt_num.text = tmp.ToString();
    }
}

 
