using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memo_on : MonoBehaviour
{
    public GameObject pann;
    public GameObject bookcase1;
    public GameObject bookcase2;
    public GameObject bookcase3;
    public GameObject sofa1;
    public GameObject sofa2;
    public GameObject sofa3;
    public GameObject window1;
    public GameObject window2;
    public GameObject window3;
    public GameObject stand1;
    public GameObject stand2;
    public GameObject stand3;
    public GameObject btn_scenechange;



    public void change_bookcase()
    {
        if (bookcase1.gameObject.activeSelf == true) //1이 켜져있으면 1 끄고 2 켜기
        {
            bookcase1.gameObject.SetActive(false);
            bookcase2.gameObject.SetActive(true);
        }
        else if (bookcase2.gameObject.activeSelf == true) //2가 켜져있으면 2 끄고 3 켜기
        {
            bookcase2.gameObject.SetActive(false);
            bookcase3.gameObject.SetActive(true);
        }
        else if (bookcase3.gameObject.activeSelf == true) //3이 켜져있으면 3 끄고 1 켜기
        {
            bookcase3.gameObject.SetActive(false);
            bookcase1.gameObject.SetActive(true);
        }
    }

    public void change_sofa()
    {
        if (sofa1.gameObject.activeSelf == true) //1이 켜져있으면 1 끄고 2 켜기
        {
            sofa1.gameObject.SetActive(false);
            sofa2.gameObject.SetActive(true);
        }
        else if (sofa2.gameObject.activeSelf == true) //2가 켜져있으면 2 끄고 3 켜기
        {
            sofa2.gameObject.SetActive(false);
            sofa3.gameObject.SetActive(true);
        }
        else if (sofa3.gameObject.activeSelf == true) //3이 켜져있으면 3 끄고 1 켜기
        {
            sofa3.gameObject.SetActive(false);
            sofa1.gameObject.SetActive(true);
        }
    }

    public void change_window()
    {
        if (window1.gameObject.activeSelf == true) //1이 켜져있으면 1 끄고 2 켜기
        {
            window1.gameObject.SetActive(false);
            window2.gameObject.SetActive(true);
        }
        else if (window2.gameObject.activeSelf == true) //2가 켜져있으면 2 끄고 3 켜기
        {
            window2.gameObject.SetActive(false);
            window3.gameObject.SetActive(true);
        }
        else if (window3.gameObject.activeSelf == true) //3이 켜져있으면 3 끄고 1 켜기
        {
            window3.gameObject.SetActive(false);
            window1.gameObject.SetActive(true);
        }
    }

    public void change_stand()
    {
        if (stand1.gameObject.activeSelf == true) //1이 켜져있으면 1 끄고 2 켜기
        {
            stand1.gameObject.SetActive(false);
            stand2.gameObject.SetActive(true);
        }
        else if (stand2.gameObject.activeSelf == true) //2가 켜져있으면 2 끄고 3 켜기
        {
            stand2.gameObject.SetActive(false);
            stand3.gameObject.SetActive(true);
        }
        else if (stand3.gameObject.activeSelf == true) //3이 켜져있으면 3 끄고 1 켜기
        {
            stand3.gameObject.SetActive(false);
            stand1.gameObject.SetActive(true);
        }
    }

    public void pop__up()
    {
        if (bookcase3.gameObject.activeSelf == true & sofa3.gameObject.activeSelf == true & window3.gameObject.activeSelf == true & stand3.gameObject.activeSelf == true)
        {
            pann.gameObject.SetActive(true);
        }
    }

    public void del_popup()
    {
        Invoke("pop__up", 0.2f);
    }

    /* public void pop__up_memo()
    {
        if (pann.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            mem_sok.gameObject.SetActive(true);
        }
    }

    public void del_popup_memo()
    {
        Invoke("pop__up_memo", 0.2f);
    } */

    void Start()
    {

    }

    void Update()
    {
        if (pann.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            pann.gameObject.SetActive(false);
            btn_scenechange.gameObject.SetActive(true);
        }
    }
}

