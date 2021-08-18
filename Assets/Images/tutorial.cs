using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorial : MonoBehaviour
{
    public GameObject blackscreen, black, ceiling, ceiling_eyes;
    public Text txt_c;
    public GameObject panel1, panel2, panel3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(blackscreen.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            blackscreen.gameObject.SetActive(false);
            ceiling_eyes.gameObject.SetActive(true);

        }

        if (ceiling_eyes.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            Invoke("screen", 1);
        }

    }
    void screen()
    {
        ceiling_eyes.gameObject.SetActive(false);
        ceiling.gameObject.SetActive(true);
    }
    public void click_c()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(true);
    }

    public void click_2()
    {
        panel2.gameObject.SetActive(false);
        panel3.gameObject.SetActive(true);
    }


    public void click_3()
    {
        panel3.gameObject.SetActive(false);
        black.gameObject.SetActive(true);
    }
}
