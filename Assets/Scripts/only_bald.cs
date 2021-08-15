using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class only_bald : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click_only_wig()
    {
        Vector2 v1;
        v1.x = -1;
        v1.y = 1;
        
        this.transform.Rotate(0, 0, 1 * speed);
    }
}
