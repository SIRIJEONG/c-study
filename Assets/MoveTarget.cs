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

        //2.SmoothDamp
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position
                                        , target, ref velo, 0.1f); //매개변수는 (현재위치,목표위치,참조속도,속도) //ref=참조접근(실시간으로 바뀌는 값 적용 가능)
    }
}
