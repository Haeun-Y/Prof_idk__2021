using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class post_it : MonoBehaviour
{

    public Text me;
    string result = "나";

    // Start is called before the first frame update
    void Start()
    {
        me.text = result;
    }

    // Update is called once per frame
    
    public void click_post()
    {
        result = null;
        me.text = result;
    }
}
