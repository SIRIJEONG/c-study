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
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);  //ForceMode: ���� �ִ� ���(����,���Թݿ�) , mass���� ���� Ŭ���� �����̴µ� �� ���� ���� �ʿ� 
    }

    // Update �� RigidBody���� �ڵ�� FixedUpdate�� �ۼ��Ѵ�.
    void FixedUpdate()
    {     //#1. �ӷ� �ٲٱ�
          //rigid.velocity = new Vector3(2, 4, 3); //velocity:���� �̵��ӵ�  


        //#2. ���� ���ϱ�
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);

        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        ////#3. ȸ����
        //rigid.AddTorque(Vector3.up); //AddTorque(Vec):Vec������ ������ ȸ������ ����
    }
}
