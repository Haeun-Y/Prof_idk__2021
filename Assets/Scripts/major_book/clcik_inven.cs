using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clcik_inven : MonoBehaviour
{
    public GameObject inven;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && inven.gameObject.activeSelf == true)
        {
            inven.gameObject.SetActive(false);
        }
    }

    public void click_inventory()
    {
        if(inven.gameObject.activeSelf == false)
        {
            inven.gameObject.SetActive(true);
        }
        
    }
}
