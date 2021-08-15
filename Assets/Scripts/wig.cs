using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wig : MonoBehaviour
{
    public GameObject bwig, success_ber;//낙서 이미지
    public Button pic;
    
    // Start is called before the first frame update
    

    public void click_pic()
    {
        bwig.gameObject.SetActive(false);
        Invoke("open_pop", 1);

    }

    public void open_pop()
    {
        success_ber.gameObject.SetActive(true);
    }
}
