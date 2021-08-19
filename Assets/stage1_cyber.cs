using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stage1_cyber : MonoBehaviour
{
    public Text txt, txt1, txt2, txt3;
    public GameObject pop_no;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void trash()
    {
        txt.text = "0";
        txt1.text = "";

        txt2.text = "";

        txt3.text = "";
    }
    public void click_na()
    {
        string str = txt.text;
        switch(str)
        {
            case "0":
                txt1.text = "나";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "1":
                txt2.text = "나";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "2":
                pop_no.gameObject.SetActive(true);
                break;

        }
    }

    public void click_prof()
    {
        string str = txt.text;
        switch (str)
        {
            case "0":
                txt1.text = "교수님";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "1":
                txt2.text = "교수님";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "2":
                pop_no.gameObject.SetActive(true);
                break;

        }
        
    }
    public void click_mola()
    {
        string str = txt.text;
        switch (str)
        {
            case "0":
            case "1":
                pop_no.gameObject.SetActive(true);
                break;
            case "2":
                txt3.text = "모른";
                txt.text = (int.Parse(str) + 1).ToString();
                break;

        }
    }
    public void click_know()
    {
        string str = txt.text;
        switch (str)
        {
            case "0":
            case "1":
                pop_no.gameObject.SetActive(true);
                break;
            case "2":
                txt3.text = "알고있";
                txt.text = (int.Parse(str) + 1).ToString();
                break;

        }
    }
    public void click_vector()
    {
        string str = txt.text;
        switch (str)
        {
            case "0":
                txt1.text = "방향";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "1":
                txt2.text = "방향";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "2":
                pop_no.gameObject.SetActive(true);
                break;

        }
    }

    public void click_exam()
    {
        string str = txt.text;
        switch (str)
        {
            case "0":
                txt1.text = "시험범위";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "1":
                txt2.text = "시험범위";
                txt.text = (int.Parse(str) + 1).ToString();
                break;
            case "2":
                pop_no.gameObject.SetActive(true);
                break;

        }
    }
}
