﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move_left : MonoBehaviour
{
    public GameObject p1, p3, p5, p7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void turn_the_page_left()
    {
        for (int i = 0; i < 1; i++)
        {
            if (p1.gameObject.activeSelf == true)
            {
                //첫번째 페이지에서 왼쪽으로 가기 누르면 아무일 안일어남
                break;

            }

            if (p3.gameObject.activeSelf == true)
            {
                p3.gameObject.SetActive(false);
                p1.gameObject.SetActive(true);
                break;
            }

            if (p5.gameObject.activeSelf == true)
            {
                p5.gameObject.SetActive(false);
                p3.gameObject.SetActive(true);
                break;
            }

            if (p7.gameObject.activeSelf == true)
            {
                p7.gameObject.SetActive(false);
                p5.gameObject.SetActive(true);
                break;
            }
            
        }

    }


}
