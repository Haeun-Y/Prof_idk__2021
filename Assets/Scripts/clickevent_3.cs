using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickevent_3 : MonoBehaviour
{
    public GameObject note10, note11, note15, book, pop_lock;
    public Image item_key;
    public Button btn_lock, btn_note11, btn_note15;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (note10.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note10.gameObject.SetActive(false);
            btn_lock.GetComponent<Button>().interactable = false;//쪽지 획득하면 서랍버튼 interactable false +) 추가할 것 : 인벤토리에 저장

        }

        else if (note11.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note11.gameObject.SetActive(false);
            btn_note11.gameObject.SetActive(false);//쪽지 획득하면 쪽지버튼 setactive false +)추가할 것 : 인벤토리에 저장
        }

        else if (note15.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            note15.gameObject.SetActive(false);
            btn_note15.gameObject.SetActive(false);//쪽지 획득하면 쪽지버튼 setactive false +)추가할 것 : 인벤토리에 저장

        }
        else if (book.gameObject.activeSelf == true && Input.GetMouseButtonDown(0))
        {
             book.gameObject.SetActive(false);
        }

    }

    public void click_book()//책 클릭 이벤트
    {
        if (book.gameObject.activeSelf == false)
        {
            book.gameObject.SetActive(true);
        }
    }

    public void click_drawer()//잠겨진 서랍 클릭이벤트
    {
        //if문으로 조건 추가 -> 열쇠를 보유하고 있으면 아니면 또 다르게
        if (item_key.gameObject.activeSelf == true && note10.gameObject.activeSelf == false)
        {
            note10.gameObject.SetActive(true);
            item_key.gameObject.SetActive(false);
        }

        else
        {
            pop_lock.gameObject.SetActive(true);
        }


    }

    public void click_note11()//쪽지 클릭 이벤트
    {
        if (note11.gameObject.activeSelf == false)
        {
            note11.gameObject.SetActive(true);
        }


    }

    public void click_note15()//쪽지 클릭 이벤트
    {
        if (note15.gameObject.activeSelf == false)
        {
            note15.gameObject.SetActive(true);
        }

    }

}
