using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlock_hint : MonoBehaviour
{
    public GameObject popup;
    public GameObject idphoto;
    public GameObject fold_memo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popup_not()
    {
        popup.gameObject.SetActive(true);
    }

    public void unlock_block()
    {
        if(popup.gameObject.activeSelf == true)
        {
            fold_memo.gameObject.SetActive(false);
            popup.gameObject.SetActive(false);
            idphoto.gameObject.SetActive(false);
        }
    }
}
