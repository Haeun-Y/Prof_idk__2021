using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickevent_4 : MonoBehaviour
{
    public GameObject note16, color_lock;
    public Button btn_note16;
    //color_lock 비활성화, 화면 닫기 등등은 다른 script에서 구현
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (note16.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note16.gameObject.SetActive(false);
            btn_note16.gameObject.SetActive(false);//쪽지 획득하면 쪽지 버튼 setactive false +) 추가할 것 : 인벤토리에 저장

        }


    }

    public void click_note16()//쪽지 16 클릭 이벤트
    {
        if (note16.gameObject.activeSelf == false)
        {
            note16.gameObject.SetActive(true);
        }
    }

    public void click_color_lock()//색 잠금장치 클릭 이벤트
    {
        if (color_lock.gameObject.activeSelf == false)
        {
            color_lock.gameObject.SetActive(true);
        }
    }



}
