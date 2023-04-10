using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{

    Vector3 target = new Vector3(10, 0.1f, 3);

    void Update()
    {
        //1.MoveTowards=등속이동 
        //transform.position =
        //    Vector3.MoveTowards(transform.position
        //                               , target, 1f); //매개변수는 (현재위치,목표위치,속도)로 구성 

        ////2.SmoothDamp
        //Vector3 velo = Vector3.zero;

        //transform.position =
        //    Vector3.SmoothDamp(transform.position
        //                                , target, ref velo, 0.1f); //매개변수는 (현재위치,목표위치,참조속도,속도) //ref=참조접근(실시간으로 바뀌는 값 적용 가능)


        ////3/Lerp(선형 보간)
        //transform.position =
        //    Vector3.Lerp(transform.position
        //                                , target, 0.05f); 


        ////4.SLerp(구면 선형 분감)
        //transform.position =
        //    Vector3.Slerp(transform.position
        //                                , target, 0.1f); //포물선 이동 


        ////5.Time.deltaRime (이전 프레임의 완료까지 걸린시간)
        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal") * Time.deltaTime
        //    Input.GetAxisRaw("Vertical") * Time.deltaTime);
        //transform.Translate(vec);

    }
}
