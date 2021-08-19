using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next_saying_3_3 : MonoBehaviour
{
    public GameObject txt1, txt2, txt3, txt4, txt5;
    public GameObject info, box, btn_to_3_3;

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
            box.gameObject.SetActive(false);
            info.gameObject.SetActive(true);
        }

        else if (info.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            info.gameObject.SetActive(false);
            box.gameObject.SetActive(true);
            txt5.gameObject.SetActive(true);
        }

        else if (txt5.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            btn_to_3_3.gameObject.SetActive(true);
        }


        /*else if (info.gameObject.activeSelf == true & cybercampus.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            info.gameObject.SetActive(false);
            box.gameObject.SetActive(true);
            txt4.gameObject.SetActive(true);
        }

        else if (info.gameObject.activeSelf == true & txt4.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            desk.gameObject.SetActive(true);
            box.gameObject.SetActive(false);
        }*/

    }
}
