using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_the_room : MonoBehaviour
{
    public GameObject plane1, plane2, plane3, plane4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_left()
    {
        if (plane1.activeSelf == true)
        {
            plane1.SetActive(false);
            plane4.SetActive(true);
        }

        else if (plane2.activeSelf == true)
        {
            plane2.SetActive(false);
            plane1.SetActive(true);
        }

        else if(plane3.activeSelf == true)
        {
            plane3.SetActive(false);
            plane2.SetActive(true);
        }
        
        else if(plane4.activeSelf == true)
        {
            plane4.SetActive(false);
            plane3.SetActive(true);
        }
        
    }

    public void click_right()
    {

        if (plane1.activeSelf == true)
        {
            plane1.SetActive(false);
            plane2.SetActive(true);
        }

        else if (plane2.activeSelf == true)
        {
            plane2.SetActive(false);
            plane3.SetActive(true);
        }

        else if (plane3.activeSelf == true)
        {
            plane3.SetActive(false);
            plane4.SetActive(true);
        }

        else if (plane4.activeSelf == true)
        {
            plane4.SetActive(false);
            plane1.SetActive(true);
        }
    }


}
