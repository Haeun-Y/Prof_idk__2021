using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hlock_4 : MonoBehaviour
{
    public SpriteRenderer color1, color2, color3, color4, color5;
    public GameObject fst, snd, thrd, fth, fifth;
    public Text now_num;
    public int num;
    public string now_str;
    // Start is called before the first frame update
    void Start()
    {
        now_str = now_num.text;
        num = now_str.Length;
        color1 = fst.gameObject.GetComponent<SpriteRenderer>();
        color2 = snd.gameObject.GetComponent<SpriteRenderer>();
        color3 = thrd.gameObject.GetComponent<SpriteRenderer>();
        color4 = fth.gameObject.GetComponent<SpriteRenderer>();
        color5 = fifth.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_red()
    {

    }

    public void click_yellow()
    {

        num = now_str.Length;
        switch(num)
        {
            case 0:
                now_str = "2";
                color1.material.color = Color.yellow;
                break;
            case 1:
                now_str += "2";
                color2.material.color = Color.yellow;
                break;
            case 2:
                now_str = "2";
                color3.material.color = Color.yellow;
                break;
            case 3:
                now_str += "2";
                color4.material.color = Color.yellow;
                break;
            case 4:
                now_str += "2";
                color5.material.color = Color.yellow;
                break;
            default:
                now_str += "2";
                break;
        }
    }

    public void click_green()
    {

    }

    public void click_blue()
    {

    }

    public void click_purple()
    {

    }
}
