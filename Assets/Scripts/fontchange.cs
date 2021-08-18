using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fontchange : MonoBehaviour
{
    public GameObject font1, font2, font3, font4, font5;
    public GameObject f51, f52, f53, f54, f55;
    public GameObject btn_num;

    public void change_font1to2()
    {
        font1.gameObject.SetActive(false);
        font2.gameObject.SetActive(true);
        f51.gameObject.SetActive(false);
        f52.gameObject.SetActive(true);
    }

    public void change_font2to3()
    {
        font2.gameObject.SetActive(false);
        font3.gameObject.SetActive(true);
        f52.gameObject.SetActive(false);
        f53.gameObject.SetActive(true);
    }

    public void change_font3to4()
    {
        font3.gameObject.SetActive(false);
        font4.gameObject.SetActive(true);
        f53.gameObject.SetActive(false);
        f54.gameObject.SetActive(true);
    }

    public void change_font4to5()
    {
        font4.gameObject.SetActive(false);
        font5.gameObject.SetActive(true);
        f54.gameObject.SetActive(false);
        f55.gameObject.SetActive(true);
        btn_num.gameObject.SetActive(true);
    }

    public void change_font5to1()
    {
        font5.gameObject.SetActive(false);
        font1.gameObject.SetActive(true);
        f55.gameObject.SetActive(false);
        f51.gameObject.SetActive(true);
        btn_num.gameObject.SetActive(false);
    }


}
