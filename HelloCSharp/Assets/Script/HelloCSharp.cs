using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{

    void Start()
    {
        //형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        //자동 형변환(잃어버리는 정보가 없음)
        heightDetail = height;

        //직접 명시해야 하는 경우(잃어버리는 정보가 있으면)
        height = (int)heightDetail;

        //조건문 (if문)
        bool isboy = true;

        if(isboy == true)
        {
            Debug.Log("나는 남자다");
        }
        else
        {
            Debug.Log("나는 여자다");
        }

        isboy = false;

        if(isboy == true)
        {
            Debug.Log("나는 남자다");
        }
        else
        {
            Debug.Log("나는 여자다");
        }

        if(isboy)
        {
            Debug.Log("나는 남자다");
        }
        if(!isboy)
        {
            Debug.Log("나는 여자다");
        }

        //관계 연산자 ==, !=, <, >

        int love = 60;

        if(love < 50)
        {
            Debug.Log("베드 엔딩");
        }
        else
        {
            Debug.Log("해피 엔딩");
        }

        int age = 17;

        // A or B 
        // A 또는 B 둘 중 하나라도 참이면 참
        if(age >= 60 || age <=17)
        {
            Debug.Log("일을 하면 안된다.");
        }

        // A and B
        // A, B 둘다 참이여야 참
        if(age < 60 && age >17)
        {
            Debug.Log("일할 나이");
        }

        if(age <= 7)
        {
            Debug.Log("유치원에 간다.");
        }
        else if(age < 12)
        {
            Debug.Log("초등학교에 간다.");
        }
        else if(age < 15)
        {
            Debug.Log("중학교에 간다.");
        }
        else if (age < 18)
        {
            Debug.Log("고등학교에 간다.");
        }
        else
        {
            Debug.Log("성인");
        }

        int year = 2017;

        switch(year)
        {
            case 2012 : 
                Debug.Log("레미 제라블");
                break;
            
            case 2015 : 
                Debug.Log("러브 라이브");
                break;
            
            case 2016 : 
                Debug.Log("트랜스포머5");
                break;
            
            case 2017 : 
                Debug.Log("곡성");
                break;
            
            default :
                Debug.Log("년도가 해당사항이 없음");
                break;
        }

        for(int i = 0;i<10;i++)
        {
            Debug.Log("지금 순번은 : "+i);
        }
        Debug.Log("루프 끝");

        bool isshot = false;
        int index = 0;
        int luckyNumber = 4;

        while(!isshot)
        {
            index++;
            
            Debug.Log("현재 시도 : " + index);
            
            if(index == luckyNumber)
            {
                Debug.Log("총알에 맞았다");
                isshot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았다.");
            }
        }
    
        do{
            Debug.Log("Do WHile!");
        }while(!isshot);



    }

    
}
