using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next_saying_3_1 : MonoBehaviour
{
    public GameObject txt1, txt2, txt3, txt4;
    public GameObject desk, cybercampus, info, box, btn_unlock, btn_phone;

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
            desk.gameObject.SetActive(true);
            box.gameObject.SetActive(false);
        }

        else if (desk.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            desk.gameObject.SetActive(false);
            cybercampus.gameObject.SetActive(true);
            btn_phone.gameObject.SetActive(true);
        }
        else if (cybercampus.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        { 
            info.gameObject.SetActive(true);
            btn_unlock.gameObject.SetActive(true);
            
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
