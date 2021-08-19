using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hclickevent_note4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject note4;

    // Update is called once per frame
    void Update()
    {
        if(note4.gameObject.activeSelf==true && Input.GetMouseButtonDown(0))
        {
            note4.gameObject.SetActive(false);
        }
    }
}
