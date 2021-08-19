using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickevent_2 : MonoBehaviour
{
    public GameObject note2, note8, big_lock;
    // Start is called before the first frame update
    public Button btn_note2, btn_note8;
    //2면이 lock은 별도의 script 작성
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (note2.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note2.gameObject.SetActive(false);
            btn_note2.gameObject.SetActive(false);//쪽지 획득하면 쪽지버튼 비활성화 +) 추가할 것 : 인벤토리에 저장
        }

        else if (note8.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note8.gameObject.SetActive(false);
            btn_note8.gameObject.SetActive(false);//쪽지 획득하면 쪽지버튼 비활성화 +) 추가할 것 : 인벤토리에 저장


        }

    }

    public void click_note2()//쪽지 클릭 이벤트
    {
        if (note2.gameObject.activeSelf == false)
        {
            note2.gameObject.SetActive(true);
        }
    }

    public void click_note8()//방문 클릭이벤트
    {
        if (note8.gameObject.activeSelf == false)
        {
            note8.gameObject.SetActive(true);
        }


    }

    public void click_lock()//잠금장치 클릭 이벤트
    {
        if (big_lock.gameObject.activeSelf == false)
        {
            big_lock.gameObject.SetActive(true);
        }


    }

    
}
