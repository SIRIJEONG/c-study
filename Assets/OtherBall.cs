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

    private void OnCollisionEnter(Collision collision)  //CollisionEnter(�浹) : ������ �浹�� ������ �� ȣ��Ǵ� �Լ� / collision : �浹 ���� Ŭ����
    {
        if(collision.gameObject.name == "IronBall")
        mat.color = new Color(0, 0, 0);  // color : �⺻ ���� Ŭ���� , color32 : 255 ���� Ŭ���� 
    }
    //private void OnCollisionStay(Collision collision)  //CollisionStay(�浹) : ������ �浹�� �Ͼ�� ���� �� ȣ��Ǵ� �Լ� 
    //{

    //}
    private void OnCollisionExit(Collision collision) // CollisionExit: ������ �浹�� ������ �� ȣ��Ǵ� �Լ� 
    {
        if (collision.gameObject.name == "IronBall")
            mat.color = new Color(1, 1, 1);  // color : �⺻ ���� Ŭ���� , color32 : 255 ���� Ŭ���� 
    }


}
