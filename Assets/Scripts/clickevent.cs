using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickevent : MonoBehaviour
{
    public GameObject baby, big_key, panel_lock, note1, big_frame, pic_baby, pop_hidden;
    public Image item_key;
    public Button btn_key, btn_note1;
    //lock은 다른 script에서 비활성화 시키기 setactive 말고 interactive인가 그거 쓰기
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (big_frame.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
           big_frame.gameObject.SetActive(false);

            
        }

        else if (baby.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
             baby.gameObject.SetActive(false);
            pic_baby.gameObject.SetActive(false);
          

        }

        else if (big_key.gameObject.activeSelf == true && Input.GetMouseButtonDown(0) && item_key.gameObject.activeSelf == false)
        {
           big_key.gameObject.SetActive(false);
           btn_key.gameObject.SetActive(false);//열쇠획득하면 열쇠버튼 비활성화 +) 추가할 것 : 인벤토리에 저장
           item_key.gameObject.SetActive(true);

        }
        else if (note1.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
           note1.gameObject.SetActive(false);
            btn_note1.gameObject.SetActive(false);//쪽지1 획득하면 쪽지버튼 비활성화 +) 추가할 것 : 인벤토리에 저장

        }
    }

    public void click_frame()//액자 클릭 이벤트
    {
        if(big_frame.gameObject.activeSelf == false)
        {
            big_frame.gameObject.SetActive(true);
        }
    }

    public void click_door()//방문 클릭이벤트
    {
        if (baby.gameObject.activeSelf == false)
        {
            baby.gameObject.SetActive(true);
            pic_baby.gameObject.SetActive(true);
            //if(업적획득을 하지 않았으면)
            Invoke("open_hidden", 0.5f);
        }


    }

    public void open_hidden()
    {
        pop_hidden.gameObject.SetActive(true);
    }

    public void click_key()//열쇠걸이 클릭 이벤트
    {
        if (big_key.gameObject.activeSelf == false)
        {
            big_key.gameObject.SetActive(true);
        }
       

    }

    public void click_note1()//쪽지 클릭 이벤트
    {
        if (note1.gameObject.activeSelf == false)
        {
            note1.gameObject.SetActive(true);
        }
      
    }

    public void click_lock()//잠금장치 클릭 이벤트
    {
        if (panel_lock.gameObject.activeSelf == false)
        {
            panel_lock.gameObject.SetActive(true);
        }
      
    }
}
