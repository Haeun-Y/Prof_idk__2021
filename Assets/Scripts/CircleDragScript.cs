using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CircleDragScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition;//드롭하면 다시 원위치로 보내기 위한 변수 
    public Image arrow;
    public Image hwa, sal, pyo;
    public GameObject pop_up;



    // Start is called before the first frame update
   /* void Start()
    {
        //pos_post = post_it.gameObject.transform.position;
        //Debug.Log(pos_post);
        //Debug.Log(pos_post.x);
        //1195.4, 731.6
        pos_post = leftt.gameObject.transform.position;
        Debug.Log(pos_post);

        pos_post = rightt.gameObject.transform.position;
        Debug.Log(pos_post);

        pos_post = leftb.gameObject.transform.position;
        Debug.Log(pos_post);

        pos_post = rightb.gameObject.transform.position;
        Debug.Log(pos_post);

    }*/

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
        //this.transform.position = defaultposition;
        Vector2 definPos = Input.mousePosition;
        
        if(definPos.x > 1039.7 && definPos.x < 1354 && definPos.y < 857 && definPos.y > 608.3)//포스트잇 위치에 드랍할 때
        {
            this.gameObject.SetActive(false);
            hwa.gameObject.SetActive(true);
            sal.gameObject.SetActive(true);
            pyo.gameObject.SetActive(true);

            Invoke("pop_direction", 1);
            
        }
        
        else
        {
            this.transform.position = defaultposition;
        }
        
        
    }

    public void pop_direction()
    {
        pop_up.gameObject.SetActive(true);
    }
}
