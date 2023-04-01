using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무키를 눌렀습니다.");
        //if (Input.anyKey)
        //    Debug.Log("플레이어가 아무키를 누르고있습니다.");



        // 키보드 행동 지표 누르기 / 누르고있기 / 때기
        //if (Input.GetKeyDown(KeyCode.Return)) //엔터키
        //    Debug.Log("아이템을 구입하였습니다.");
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    Debug.Log("왼쪽으로 이동 중");
        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //    Debug.Log("오른쪽 이동을 멈추었습니다.");



        //if (Input.GetMouseButtonDown(0))
        //    Debug.Log("미사일발사!");
        //if (Input.GetMouseButton(0))
        //    Debug.Log("미사일 모으는 중...");
        //if (Input.GetMouseButtonUp(0))
        //    Debug.Log("슈퍼 미사일 발사 !!");


        //if (Input.GetButtonDown("SuperFire")) //점프를 할때는 보통 다운을 안쓴다.
        //    Debug.Log("필살기!");
        //if (Input.GetButton("Jump"))
        //    Debug.Log("점프 모으는 중...");
        //if (Input.GetButtonUp("Jump"))
        //    Debug.Log("슈퍼 점프");

        if (Input.GetButton("Horizontal"))
            Debug.Log("횡 이동중 ..." + Input.GetAxisRaw("Horizontal")); //중간값을 나타내려면 Raw를 뺀다

        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동중 ..." + Input.GetAxisRaw("Vertical")); 
    }
}
