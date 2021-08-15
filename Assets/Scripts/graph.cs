using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graph : MonoBehaviour
{
    private static graph _instance = null;

    public static graph Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject.FindObjectOfType<graph>();

                if (_instance == null)
                {
                    Debug.LogError("There's no active TabController object");
                }
            }
            return _instance;
        }
    }

    dot tabButton;

    private void Start()
    {
        SelectedButton(transform.GetChild(13).GetComponent<dot>());
    }

    public void SelectedButton(dot _button)
    {

        if (tabButton != null)
        {
            tabButton.Deselect();
        }

        tabButton = _button;
        tabButton.Select();
    }

}