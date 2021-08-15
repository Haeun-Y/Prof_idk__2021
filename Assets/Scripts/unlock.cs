using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class unlock : MonoBehaviour
{
    public Button lock_direction;
    public GameObject unlock_arrow;
    // Start is called before the first frame update
    
    public void click_44()
    {
        Invoke("pop_unlock", 1);
    }

    public void click_okay()
    {
        unlock_arrow.gameObject.SetActive(false);
        lock_direction.gameObject.SetActive(false);
    }

    public void pop_unlock()
    {
        unlock_arrow.gameObject.SetActive(true);
    }

    
}
