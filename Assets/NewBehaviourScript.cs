using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        //1.����
        int level = 5;
        float strength = 15.5f;
        string playerName = "����";
        bool isFullLevel = false;

        // ���� -> �ʱ�ȭ  -> ȣ��(���) 
        //Debug.Log("����� �̸���?");
        //Debug.Log(playerName);
        //Debug.Log("����� ������?");
        //Debug.Log(level);
        //Debug.Log("����� ����?");
        //Debug.Log(strength);
        //Debug.Log("���� �����ΰ�?");
        //Debug.Log(isFullLevel);

        //2.�׷��� ���� 
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        //Debug.Log("�ʿ� �����ϴ� ����");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        //items.RemoveAt(0);//���ϴ� ����Ʈ�� ���� �� �� �ִ�.

        //Debug.Log("������ �ִ� ������");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]); // �ι�° �������� ���µ� ã������ �ϸ�  ������ ���.

        //3.������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����??");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);// %�� ���� �ƴ� �������� ���
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("����� ���°� ���޴ϱ�?" + isBadCondition);



    }


}