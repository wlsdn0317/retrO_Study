using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //Update는 대략 1초에 60번
    void Update()
    {
        // 1번에 60도
        transform.Rotate(60 * Time.deltaTime, 60*Time.deltaTime, 60 * Time.deltaTime);

        //Time.deltatime 은 화면이 한번 깜빡이는 시간 = 한 프레임의 시간 
        //화면을 60번 깜박이면 (초당 60프레임) 1/60
        //화면을 200번 깜박이면 (초당 200프레임) 1/200

    }

    //니드 포 스피드 - 엑스박스 콘솔 / PC판
    //프레임 락
}
