using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class hzoom_btn : MonoBehaviour
{
    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;
    public Sprite btn_selected, btn_de;

    private void Start()
    {
        btn_de = this.GetComponent<Image>().sprite;
    }
    public void Select()
    {
        
        if (onTabSelected != null)
        {

            this.GetComponent<Image>().sprite = btn_selected;
            onTabSelected.Invoke();
        }
    }

    

    public void Deselect()
    {
        if (onTabDeselected != null)
        {
            this.GetComponent<Image>().sprite = btn_de;
            onTabDeselected.Invoke();
        }
    }

    public void OnSelectTab(hzoom_btn button)
    {
        hzoom.Instance.SelectedButton(button);
    }
}