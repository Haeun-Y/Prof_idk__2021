using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next_saying : MonoBehaviour
{
    public GameObject txt1, txt2, txt3, txt4, txt5, txt6, txt7;
    public GameObject panell;
    public GameObject info;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (txt1.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt1.gameObject.SetActive(false);
            txt2.gameObject.SetActive(true);
        }

        else if (txt2.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt2.gameObject.SetActive(false);
            txt3.gameObject.SetActive(true);
        }

        else if (txt3.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt3.gameObject.SetActive(false);
            txt4.gameObject.SetActive(true);
        }

        else if (txt4.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt4.gameObject.SetActive(false);
            txt5.gameObject.SetActive(true);
        }

        else if (txt5.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            panell.gameObject.SetActive(true);
        }

        /*else if (panell.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            panell.gameObject.SetActive(false);
            txt5.gameObject.SetActive(false);
            txt6.gameObject.SetActive(true);
        }*/

        else if (txt6.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt6.gameObject.SetActive(false);
            txt7.gameObject.SetActive(true);
        }

        else if (txt7.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            info.gameObject.SetActive(true);
        }

    }
}
