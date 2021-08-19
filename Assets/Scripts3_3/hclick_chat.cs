using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hclick_chat : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img1_1, img1_2, img1_3,img1_4, img2_1, img2_2, img2_3, img2_4, img2_5,img2_6, img3_1, img3_2, img3_3, img3_4;
    public GameObject pop_hidden_chat;
    public Button first, second, third;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chat1_1()
    {
        img1_1.gameObject.SetActive(true);
    }
    public void chat1_2()
    {
        img1_2.gameObject.SetActive(true);
    }

    public void chat1_3()
    {
        img1_3.gameObject.SetActive(true);
    }
    public void chat1_4()
    {
        img1_4.gameObject.SetActive(true);
    }
    public void chat2_1()
    {
        img2_1.gameObject.SetActive(true);
    }
    public void chat2_2()
    {
        img2_2.gameObject.SetActive(true);
    }

    public void chat2_3()
    {
        img2_3.gameObject.SetActive(true);
    }

    public void chat2_4()
    {
        img2_4.gameObject.SetActive(true);
    }
    public void chat2_5()
    {
        img2_5.gameObject.SetActive(true);
    }
    public void chat2_6()
    {
        img2_6.gameObject.SetActive(true);
    }

    public void chat3_1()
    {
        img3_1.gameObject.SetActive(true);
    }
    public void chat3_2()
    {
        img3_2.gameObject.SetActive(true);
    }

    public void chat3_3()
    {
        img3_3.gameObject.SetActive(true);
    }
    public void chat3_4()
    {
        img3_4.gameObject.SetActive(true);
    }
    public void click_1()
    {
        first.gameObject.SetActive(false);
        second.gameObject.SetActive(false);
        third.gameObject.SetActive(false);
        Invoke("chat1_1", 0.5f);
        Invoke("chat1_2", 1.5f);
        Invoke("chat1_3", 2.5f);
        Invoke("chat1_4", 3.5f);

    }

    public void click_2()
    {
        first.gameObject.SetActive(false);
        second.gameObject.SetActive(false);
        third.gameObject.SetActive(false);
        Invoke("chat2_1", 0.5f);
        Invoke("chat2_2", 1.5f);
        Invoke("chat2_3", 2.5f);
        Invoke("chat2_4", 3.5f);
        Invoke("chat2_5", 4.5f);
        Invoke("chat2_6", 5.5f);
    }

    void complete()
    {
        pop_hidden_chat.gameObject.SetActive(true);
    }
    public void click_3()
    {
        first.gameObject.SetActive(false);
        second.gameObject.SetActive(false);
        third.gameObject.SetActive(false);
        Invoke("chat3_1", 0.5f);
        Invoke("chat3_2", 1.5f);
        Invoke("chat3_3", 2.5f);
        Invoke("chat3_4", 3.5f);
        Invoke("complete", 4.5f);
    }
}
