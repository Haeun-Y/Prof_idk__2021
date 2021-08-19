using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class h_chat_input : MonoBehaviour
{
    public Button first, second, third;
    // Start is called before the first frame update
    public void click_input()
    {
        first.gameObject.SetActive(true);
        second.gameObject.SetActive(true);
        third.gameObject.SetActive(true);
    }
}
