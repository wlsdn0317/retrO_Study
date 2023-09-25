using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    void Start()
    {
        //주석
        /*
            여러줄에 걸친 주석
        */
        //콘솔 출력
        Debug.Log("Hello World!");

        //숫자형 변수
        //int 소숫점이 없는 정수
        int age = 32;
        int money = -1000;
        Debug.Log(age);
        Debug.Log(money);

        //float 소숫점이 잇는 실수
        //float 소숫점 아래 7자리까지만 정확
        //floating point
        float height = 123.456f; 

        //float의 두배의 메모리를 사용 64비트
        //소숫점 아래 15자리까지만 정확 
        double pi = 3.141592265359;

        //bool은 참 거짓 true, false
        bool isBoy = true;
        bool isGilr = false;

        //char character 한문자
        char grade = 'A';

        //string은 문장
        string movieTitle = "러브라이브!!";

        Debug.Log("내 나이는!: " + age);

        Debug.Log("내가 가진 돈은!: "+money);

        Debug.Log("내 키는 : " + height);

        Debug.Log("원주율은 : " + pi);

        Debug.Log("내 성적은 : "+ grade);

        Debug.Log("명작 영화는 : " + movieTitle); 

        Debug.Log("나는 남자인가?" + isBoy);

        Debug.Log("나는 여자인가?" + isGilr);
        
        // var은 할당되는 값을 기준으로 타입을 결정;
        var myName = "I_Jinwoo";    
         
        Debug.Log("진우의 닉네임" + myName);

    
    }

}
