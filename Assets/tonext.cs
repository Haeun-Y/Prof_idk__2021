using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tonext : MonoBehaviour
{
    public Text txt;
    public GameObject pop_next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click_next()
    {
        string str = txt.text;
        if(int.Parse(str) >= 3)
        {
            pop_next.gameObject.SetActive(true);
        }
    }
}
