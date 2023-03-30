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
        if (Input.anyKey)
            Debug.Log("플레이어가 아무키를 누르고있습니다.");
    }
}
