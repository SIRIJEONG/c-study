using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "애플";
        bool isFullLevel = false;

        // 선언 -> 초기화  -> 호출(사용) 
        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel);

        //2.그룹형 변수 
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        //items.RemoveAt(0);//원하는 리스트를 삭제 할 수 있다.

        //Debug.Log("가지고 있는 아이템");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]); // 두번째 아이템이 없는데 찾으려고 하면  오류가 뜬다.

        //3.연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은??");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);// %는 몫이 아닌 나머지를 출력
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);



    }


}