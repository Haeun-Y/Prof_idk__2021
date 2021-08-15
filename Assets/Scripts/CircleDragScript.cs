using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CircleDragScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition;//드롭하면 다시 원위치로 보내기 위한 변수 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        defaultposition = this.transform.position;//가장 먼저 드래그를 시작할 때 처음위치로 다시 돌려보내기 위해서
        //처음 위치의 좌표를 저장
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        //드래그 중일 때 현재위치를 마우스나 터치 지점을 따라가기 위해서 
        //마우스 포지션을 가져오고 transform.position에 위치를 마우스 포지션의 위치를 대입
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //이코드 의미가 뭔지
        //this.transform.position = defaultposition;
        Vector2 definPos = Input.mousePosition;
        this.transform.position = definPos;
    }

}
