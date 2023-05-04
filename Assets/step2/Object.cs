using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 vec = new Vector3(3, 0, 0); // xyz축의 값을 넣어줘야한다  (벡터 값)
        //transform.Translate(vec);  //Translate는 벡터 값을 현재 위치에 더하는 함수 


    }
    private void Update()
    {
        //Vector3 vec = new Vector3(0, 0, 0); // xyz축의 값을 넣어줘야한다  (벡터 값)
        //transform.Translate(vec);  //Translate는 벡터 값을 현재 위치에 더하는 함수 


        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // Raw를 넣으면 중간값없이 1씩 증가한다 
        transform.Translate(vec);  //Translate는 벡터 값을 현재 위치에 더하는 함수 
    }

}
