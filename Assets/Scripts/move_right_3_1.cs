using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_right_3_1 : MonoBehaviour
{
    public GameObject p1, p3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void turn_the_page_right()
    {
        p1.gameObject.SetActive(false);
        p3.gameObject.SetActive(true);
    }
}

