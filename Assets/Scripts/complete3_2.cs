using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complete3_2 : MonoBehaviour
{
    public GameObject memo1, memo2, memo3, box, img_a, btn_unlock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(memo1.gameObject.activeSelf == false & memo2.gameObject.activeSelf == false & memo3.gameObject.activeSelf == false & box.gameObject.activeSelf == false & img_a.gameObject.activeSelf == true)
        {
            btn_unlock.gameObject.SetActive(true);
        }
    }
}
