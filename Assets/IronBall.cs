using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(2,4,3); //velocity:현재 이동속도
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);  //ForceMode: 힘을 주는 방식(가속,무게반영) , mass무게 값이 클수록 움직이는데 더 많은 힘이 필요 
    }

    // Update 에 RigidBody관련 코드는 FixedUpdate에 작성한다.
    void FixedUpdate()
    {     //#1. 속력 바꾸기
          //rigid.velocity = new Vector3(2, 4, 3); //velocity:현재 이동속도  


        //#2. 힘을 가하기
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);

        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        ////#3. 회전력
        //rigid.AddTorque(Vector3.up); //AddTorque(Vec):Vec방향을 축으로 회전력이 생김
    }
}
