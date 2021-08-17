using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notion_on : MonoBehaviour
{
    public GameObject circle1, circle2, circle3, circle4;
    public GameObject notion;
    
    public void circle_1()
    {
        circle1.gameObject.SetActive(true);
    }

    public void circle_2()
    {
        circle2.gameObject.SetActive(true);
    }

    public void circle_3()
    {
        circle3.gameObject.SetActive(true);
    }

    public void circle_4()
    {
        circle4.gameObject.SetActive(true);
    }

    public void not_on()
    {
        if (circle1.gameObject.activeSelf == true & circle2.gameObject.activeSelf == true & circle3.gameObject.activeSelf == true & circle4.gameObject.activeSelf == true)
        {
            notion.gameObject.SetActive(true);
        }
    }
}
