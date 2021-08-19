using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lock_password : MonoBehaviour
{
    public Text password;
    string input = null;
    public GameObject memoo;

    void Start()
    {
        password.text = null;
    }

    public void enter_left()
    {
        password.text = password.text + "left ";
    }

    public void enter_right()
    {
        password.text = password.text + "right ";
    }

    public void enter_up()
    {
        password.text = password.text + "up ";
    }

    public void enter_down()
    {
        password.text = password.text + "down ";
        
        if (password.text == "down right down left down right down ")
        {
            memoo.gameObject.SetActive(true);
        }
    }

    public void refresh()
    {
        input = null;
        password.text = input;
    }
}
