using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 vec = new Vector3(3, 0, 0); // xyz���� ���� �־�����Ѵ�  (���� ��)
        //transform.Translate(vec);  //Translate�� ���� ���� ���� ��ġ�� ���ϴ� �Լ� 


    }
    private void Update()
    {
        //Vector3 vec = new Vector3(0, 0, 0); // xyz���� ���� �־�����Ѵ�  (���� ��)
        //transform.Translate(vec);  //Translate�� ���� ���� ���� ��ġ�� ���ϴ� �Լ� 


        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // Raw�� ������ �߰������� 1�� �����Ѵ� 
        transform.Translate(vec);  //Translate�� ���� ���� ���� ��ġ�� ���ϴ� �Լ� 
    }

}
