using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hzoom : MonoBehaviour
{
    private static hzoom _instance = null;

    public static hzoom Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject.FindObjectOfType<hzoom>();

                if (_instance == null)
                {
                    Debug.LogError("There's no active TabController object");
                }
            }
            return _instance;
        }
    }

    hzoom_btn tabButton;

    private void Start()
    {
        
    }

    public void SelectedButton(hzoom_btn _button)
    {

        if (tabButton != null)
        {
            tabButton.Deselect();
        }

        tabButton = _button;
        tabButton.Select();
    }

}