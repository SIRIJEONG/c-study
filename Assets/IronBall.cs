using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(2,4,3); //velocity:���� �̵��ӵ�
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);  //ForceMode: ���� �ִ� ���(����,���Թݿ�) , mass���� ���� Ŭ���� �����̴µ� �� ���� ���� �ʿ� 
    }

    // Update �� RigidBody���� �ڵ�� FixedUpdate�� �ۼ��Ѵ�.
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, 3); //velocity:���� �̵��ӵ�  //#1. �ӷ� �ٲٱ�

    }
}
