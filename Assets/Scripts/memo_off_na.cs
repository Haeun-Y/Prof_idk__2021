using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memo_off_na : MonoBehaviour
{
    public GameObject memo;
    public GameObject opened_memo,btn_unlock;

    public void open_memo()
    {
        opened_memo.gameObject.SetActive(true); //쪽지 펼치기
    }

    void Start()
    {

    }

    void Update() //쪽지랑 펼쳐진 쪽지 전부 사라지게 하기
    {
        if (opened_memo.gameObject.activeSelf == true & Input.GetMouseButtonDown(0))
        {
            opened_memo.gameObject.SetActive(false); //펼쳐졌던 쪽지가 꺼짐
            memo.gameObject.SetActive(false);
            btn_unlock.gameObject.SetActive(true);
        }
    }
}
