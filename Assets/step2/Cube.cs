using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Awake() // 게임 오브젝트가 생생할 때 딱한번 실행되는 함수 
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }
    private void Start() //업데이트 시작 직전 최초 시행하는 함수 //여기까지가 초기화 영역
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    private void FixedUpdate() //물리연산 업데이트 //물리연산영역 시작 , 고정된 실행 주기로 cpu를 많이 사용 
    {
        Debug.Log("이동~");
    }
    private void Update() //게임 로직 업데이트 , 환경에 따라 실행 주기가 떨어질  수 있음
    {
        Debug.Log("몬스터 사냥!");
    }
    private void LateUpdate() //모든 업데이트 끝난 후 
    {
        Debug.Log("경험치 흭득.");
    }
    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    private void OnDestroy() //게임 오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 헤제하였습니다.");
    }
}
