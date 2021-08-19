using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class press_Enter : MonoBehaviour
{
    public GameObject now_txt, next_txt;


    void Start()
    {

    }

    void Update()
    {
        if(now_txt.gameObject.activeSelf == true & Input.GetKeyDown(KeyCode.Return))
        {
            next_txt.gameObject.SetActive(true);
        }
    }
}
