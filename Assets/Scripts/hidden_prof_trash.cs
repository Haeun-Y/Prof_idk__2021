using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hidden_prof_trash : MonoBehaviour
{
    public int num_prof, num_trash;
    //랜덤넘버 저장
    public GameObject pop_hidden_prof, pop_hidden_trash, pop_hidden;
    public Text rand_prof, rand_trash;
    //랜덤넘버에 따른 정해진 문장 저장
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //히든업적이 뜨지 않았을 때
        if(pop_hidden.gameObject.activeSelf == true && Input.GetMouseButtonDown(0) && pop_hidden_prof.gameObject.activeSelf == false && pop_hidden_trash.gameObject.activeSelf == false)
        {
            pop_hidden.gameObject.SetActive(false);
        }

        //히든업적획득이 뜰 때-> okay 버튼에 클릭 추가
        
    }
    
    public void click_prof()//교수님 눌렀을 때 반응 : 히든업적
    {
        /*-교수님이 짜증을 내시며 손을 허공에 휘두르십니다.(40%) 0 1 2 3
          -교수님이 깜짝 놀라시며 주변을 두리번거리십니다.(40%)  4 5 6 7 
          -교수님이 화면을 똑바로 쳐다보며 “이건 꿈이야.”라고 말씀하십니다. (20%) -> 히든 업적 달성 8 9
         */
        pop_hidden.gameObject.SetActive(true);
        rand_prof.gameObject.SetActive(true);
        rand_trash.gameObject.SetActive(false);
        if(rand_prof.text == "")//텍스트가 정해지지 않았을 때
        {
            num_prof = Random.Range(0, 10); //0~9사이의 랜덤 정수 반환
            switch (num_prof)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    rand_prof.text = "교수님이 짜증을 내시며 손을 허공에 휘두르십니다.";
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    rand_prof.text = "교수님이 깜짝 놀라시며 주변을 두리번거리십니다.";
                    break;

                case 8:
                case 9://히든업적 달성
                    rand_prof.text = "교수님이 화면을 똑바로 쳐다보며 “이건 꿈이야.”라고 말씀하십니다.";
                    pop_hidden_prof.SetActive(true);
                    break;
            }
        }

       
        
    }
    public void click_trash()
    {
        /*-빈 에너지 드링크 몇 캔을 발견했습니다.
        -구겨진 종이 몇 장을 발견했습니다. 
        -잉크가 닳은 볼펜 몇 자루를 발견했습니다.
        -돌이킬 수 없는 절망, 세상이 호락호락하지 않다는 걸 배워요.
        -교수님의 꿈 일기장을 발견했습니다. -> 히든 업적 달성

         */

        pop_hidden.gameObject.SetActive(true);
        rand_prof.gameObject.SetActive(false);
        rand_trash.gameObject.SetActive(true);

        if (rand_trash.text == "")//텍스트가 정해지지 않았을 때
        {
            num_prof = Random.Range(0, 10); //0~9사이의 랜덤 정수 반환
            switch (num_prof)
            {
                case 0:
                case 1:
                    rand_trash.text = "빈 에너지 드링크 몇 캔을 발견했습니다.";
                    break;
                case 2:
                case 3:
                    rand_trash.text = "구겨진 종이 몇 장을 발견했습니다.";
                    break;

                case 4:
                case 5:
                    rand_trash.text = "잉크가 닳은 볼펜 몇 자루를 발견했습니다.";
                    break;
                case 6:
                case 7:
                    rand_prof.text = "돌이킬 수 없는 절망, 세상이 호락호락하지 않다는 걸 배워요.";
                    break;

                case 8:
                case 9://히든업적 달성
                    rand_prof.text = "교수님의 꿈 일기장을 발견했습니다.";
                    pop_hidden_trash.SetActive(true);
                    break;
            }
        }

    }
}
