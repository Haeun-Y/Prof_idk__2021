using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dream : MonoBehaviour
{
    public GameObject circle1, circle2, circle3, circle4, circle5, circle6, circle7;
    public GameObject next_text;
    public GameObject success_text;
    public GameObject giveup_text;

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

    public void circle_5()
    {
        circle5.gameObject.SetActive(true);
    }

    public void circle_6()
    {
        circle6.gameObject.SetActive(true);
    }

    public void circle_7()
    {
        circle7.gameObject.SetActive(true);
    }

    public void not_on()
    {
        if (circle1.gameObject.activeSelf == true & circle2.gameObject.activeSelf == true & circle3.gameObject.activeSelf == true & circle4.gameObject.activeSelf == true & circle5.gameObject.activeSelf == true & circle6.gameObject.activeSelf == true & circle7.gameObject.activeSelf == true)
        {
            success_text.gameObject.SetActive(true);
            next_text.gameObject.SetActive(true);
            giveup_text.gameObject.SetActive(false);
        }
    }
}