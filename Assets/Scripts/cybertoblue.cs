using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cybertoblue : MonoBehaviour
{
    public GameObject a, b, c, d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_okay()
    {
        Invoke("pop_a", 1);
        Invoke("pop_b", 2f);
        Invoke("pop_c", 2.5f);
        Invoke("pop_d", 2.7f);
        Invoke("toblue", 2.8f);

    }
    
    void toblue()
    {
        SceneManager.LoadScene("stage2");
    }
    void pop_a()
    {
        a.gameObject.SetActive(true);
    }

    void pop_b()
    {
        b.gameObject.SetActive(true);
    }

    void pop_c()
    {
        c.gameObject.SetActive(true);
    }

    void pop_d()
    {
       d.gameObject.SetActive(true);
    }
}
