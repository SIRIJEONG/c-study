using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ�Ű�� �������ϴ�.");
        //if (Input.anyKey)
        //    Debug.Log("�÷��̾ �ƹ�Ű�� �������ֽ��ϴ�.");



        // Ű���� �ൿ ��ǥ ������ / �������ֱ� / ����
        //if (Input.GetKeyDown(KeyCode.Return)) //����Ű
        //    Debug.Log("�������� �����Ͽ����ϴ�.");
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    Debug.Log("�������� �̵� ��");
        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //    Debug.Log("������ �̵��� ���߾����ϴ�.");



        //if (Input.GetMouseButtonDown(0))
        //    Debug.Log("�̻��Ϲ߻�!");
        //if (Input.GetMouseButton(0))
        //    Debug.Log("�̻��� ������ ��...");
        //if (Input.GetMouseButtonUp(0))
        //    Debug.Log("���� �̻��� �߻� !!");



    }
}
