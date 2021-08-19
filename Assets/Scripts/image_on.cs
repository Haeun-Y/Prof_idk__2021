using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_on : MonoBehaviour
{
    public GameObject img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (img.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            img.gameObject.SetActive(false);
        }
    }

    public void img_on()
    {
            img.gameObject.SetActive(true);
    }
}
