using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_block : MonoBehaviour
{
    public GameObject hint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void block_click_event()
    {
        if(hint.gameObject.activeSelf== true)
        {
            hint.gameObject.SetActive(false);
        }
        else
        {
            hint.gameObject.SetActive(true);
        }
    }
}
