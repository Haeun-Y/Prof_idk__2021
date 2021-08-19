using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom_stu : MonoBehaviour
{
    public Image first, second, third;
    public Button eat, cap, sleep;
    public Sprite after_eat, after_cap, after_sleep;
    public GameObject pop_hidden_student;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("first_assistant", 1);
    }
    void first_assistant()
    {
        first.gameObject.SetActive(true);
    }

    void second_assistant()
    {
        second.gameObject.SetActive(true);
    }

    void third_assistant()
    {
        third.gameObject.SetActive(true);
    }
    void get_hidden()
    {
        pop_hidden_student.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //업적획득전이라면 if 문 추가
        if(Input.GetMouseButtonDown(0) && first.gameObject.activeSelf == true)
        {
            first.gameObject.SetActive(false);
            eat.GetComponent<Button>().interactable = true;
        }

        if (Input.GetMouseButtonDown(0) && second.gameObject.activeSelf == true)
        {
            second.gameObject.SetActive(false);
            sleep.GetComponent<Button>().interactable = true;
        }

        if (Input.GetMouseButtonDown(0) && third.gameObject.activeSelf == true)
        {
            third.gameObject.SetActive(false);
            cap.GetComponent<Button>().interactable = true;
        }


    }

    public void click_eat()
    {
        eat.GetComponent<Image>().sprite = after_eat;
        Invoke("second_assistant", 1);
    }

    public void click_sleep()
    {
        sleep.GetComponent<Image>().sprite = after_sleep;
        Invoke("third_assistant", 1);
    }

    public void click_cap()
    {
        cap.GetComponent<Image>().sprite = after_cap;
        Invoke("get_hidden", 0.5f);
    }

    
}
