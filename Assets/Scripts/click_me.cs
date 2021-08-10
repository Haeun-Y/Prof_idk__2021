using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_me : MonoBehaviour
{
    public Text txt_me;
    public string str_me;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clickevent_me()
    {
        str_me = "";
        txt_me.text = str_me; 
    }
}
