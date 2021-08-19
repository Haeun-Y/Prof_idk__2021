using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone_next : MonoBehaviour
{
    public GameObject txt1;
    public GameObject info;
    public GameObject img_c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(img_c.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt1.gameObject.SetActive(true);
            img_c.gameObject.SetActive(false);
        }

        else if (txt1.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            txt1.gameObject.SetActive(false);
            info.gameObject.SetActive(true);
        }

        
    }
}
