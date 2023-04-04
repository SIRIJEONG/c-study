using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{

    Vector3 target = new Vector3(10, 0.1f, 3);

    void Update()
    {
        //1.MoveTowards=����̵� 
        //transform.position =
        //    Vector3.MoveTowards(transform.position
        //                               , target, 1f); //�Ű������� (������ġ,��ǥ��ġ,�ӵ�)�� ���� 

        //2.SmoothDamp
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position
                                        , target, ref velo, 0.1f); //�Ű������� (������ġ,��ǥ��ġ,�����ӵ�,�ӵ�) //ref=��������(�ǽð����� �ٲ�� �� ���� ����)
    }
}
