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
        //if (Input.GetButtonDown("Jump")) {
        //    rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);

        //}
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
        //    0, Input.GetAxisRaw("Vertical"));

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);

        ////#3. ȸ����
        //rigid.AddTorque(Vector3.up); //AddTorque(Vec):Vec������ ������ ȸ������ ����
    }
    private void OnTriggerStay(Collider other) // �ݶ��̴��� ��� �浹�ϰ� ���� �� ȣ��
    {
        if (other.name == "Cube 3")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);

    }

    ////���� �������� �浹�� �߻��ϴ� �̺�Ʈ 
    //private void OnCollisionEnter(Collision collision) { }
    //private void OnCollisionStay(Collision collision) { }
    //private void OnCollisionExit(Collision collision) { }

    ////�ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
    //private void OnTriggerEnter(Collider other) { }
    //private void OnTriggerStay(Collider other) { }
    //private void OnTriggerExit(Collider other) { }


}
