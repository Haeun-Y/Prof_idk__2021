using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    private static zoom _instance = null;

    public static zoom Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject.FindObjectOfType<zoom>();

                if (_instance == null)
                {
                    Debug.LogError("There's no active TabController object");
                }
            }
            return _instance;
        }
    }

    zoom_btn tabButton;

    private void Start()
    {
        
    }

    public void SelectedButton(zoom_btn _button)
    {

        if (tabButton != null)
        {
            tabButton.Deselect();
        }

        tabButton = _button;
        tabButton.Select();
    }

}