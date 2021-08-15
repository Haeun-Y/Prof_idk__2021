using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bald : MonoBehaviour
{
   
    public Sprite after;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_wig()
    {
        this.GetComponent<Image>().sprite = after;

    }
}
