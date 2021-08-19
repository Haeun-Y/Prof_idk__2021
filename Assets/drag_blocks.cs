using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class drag_blocks : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition, defaultposition_na, defaultposition_prof, defaultposition_vector, defaultposition_exam ;//드롭하면 다시 원위치로 보내기 위한 변수 
    public GameObject na, prof, vector, exam;
    public int noun1, noun2, verb;




    // Start is called before the first frame update
    void Start()
    {/*
      * 
        v = go1_1.gameObject.transform.position;
        Debug.Log(v);


        v = go1_2.gameObject.transform.position;
        Debug.Log(v);


        v = go1_3.gameObject.transform.position;
        Debug.Log(v);


        v = go1_4.gameObject.transform.position;
        Debug.Log(v);

        v = go2_1.gameObject.transform.position;
        Debug.Log(v);


        v = go2_2.gameObject.transform.position;
        Debug.Log(v);


        v = go2_3.gameObject.transform.position;
        Debug.Log(v);


        v = go2_4.gameObject.transform.position;
        Debug.Log(v);

        v = go3_1.gameObject.transform.position;
        Debug.Log(v);


        v = go3_2.gameObject.transform.position;
        Debug.Log(v);


        v = go3_3.gameObject.transform.position;
        Debug.Log(v);


        v = go3_4.gameObject.transform.position;
        Debug.Log(v);*/
        defaultposition = this.transform.position;
        defaultposition_na = na.transform.position;
        defaultposition_prof = prof.transform.position;
        defaultposition_vector = vector.transform.position;
        defaultposition_exam = exam.transform.position;

        noun1 = 0;
        noun2 = 0;
        verb = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        //가장 먼저 드래그를 시작할 때 처음위치로 다시 돌려보내기 위해서
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



        /*499 596
        873 606
        442 402
        873 375

        905 600
        1329 610
        898 406
        1329 379

        1365 615
        1789 625
        1358 421
        1789 395

         */

        //명사
        //나 교수님 방향 시험범위
        
        if (definPos.x >= 499 && definPos.x <= 873 && definPos.y >= 375 && definPos.y <= 606)//첫번째 빈칸에 위치할때
        {
            switch(noun1)
            {
                case 0://아무것도 없을 때
                    this.transform.position = definPos;
                    
                    break;

                case 1://나 있을 때
                    na.transform.position = defaultposition_na;
                    this.transform.position = definPos;
                    break;
                case 2://교수님 있을 때
                    prof.transform.position = defaultposition_prof;
                    this.transform.position = definPos;
                    break;

                case 3://방향 있을 때
                    vector.transform.position = defaultposition_vector;
                    this.transform.position = definPos;
                    break;
                case 4://시험범위 있을 때
                    exam.transform.position = defaultposition_exam;
                    this.transform.position = definPos;
                    break;

                
            }
            noun1 = 2;
          
        }

        /*
                else if (definPos.x)//두번째 빈칸에 위치할 때
                {
                    this.transform.position = 두번째 빈칸 위치
        }
        */


        else
        {
            this.transform.position = defaultposition;
            
        }



    }

  
}
