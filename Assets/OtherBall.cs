using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)  //CollisionEnter(충돌) : 물리적 충돌이 시작할 때 호출되는 함수 / collision : 충돌 정보 클래스
    {
        if(collision.gameObject.name == "IronBall")
        mat.color = new Color(0, 0, 0);  // color : 기본 색상 클래스 , color32 : 255 색상 클래스 
    }
    //private void OnCollisionStay(Collision collision)  //CollisionStay(충돌) : 물리적 충돌이 일어나는 중일 때 호출되는 함수 
    //{

    //}
    private void OnCollisionExit(Collision collision) // CollisionExit: 물리적 충돌이 끝났을 때 호출되는 함수 
    {
        if (collision.gameObject.name == "IronBall")
            mat.color = new Color(1, 1, 1);  // color : 기본 색상 클래스 , color32 : 255 색상 클래스 
    }


}
