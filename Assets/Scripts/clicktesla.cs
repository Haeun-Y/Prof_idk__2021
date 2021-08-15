using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clicktesla : MonoBehaviour
{
    public Sprite after_tesla, after_edison;
    public Button tesla, edison;
    public GameObject panel_e,panel_t,  okay;
    public Text check_e, check_t;
    public string str_check_e = null;
    public string str_check_t = null;
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_tesla()
    {
        if(check_t.text != "1")
        {
            panel_t.SetActive(false);
            tesla.GetComponent<Image>().sprite = after_tesla;
            str_check_t = "1";
            check_t.text = str_check_t;
            if(check_e.text == "1")
            {

                Invoke("func_okay", 1);
            }
        }
        
    }

    public void click_edison()
    {
        if (check_e.text != "1")
        {
            panel_e.SetActive(false);
            edison.GetComponent<Image>().sprite = after_edison;
            str_check_e = "1";
            check_e.text = str_check_e;
            if (check_t.text == "1")
            {

                Invoke("func_okay", 1);
            }
        }
    }
    public void func_okay()
    {
        okay.SetActive(true);

    }

}
