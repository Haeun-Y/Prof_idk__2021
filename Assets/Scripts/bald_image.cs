using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bald_image : MonoBehaviour
{
    public Image wig;
    public Vector2 v_wig;
    
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
        v_wig = wig.transform.position;
        wig.transform.position = v_wig + (new Vector2(-1, 1));
        

    }
}
