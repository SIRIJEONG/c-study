using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Awake() // ���� ������Ʈ�� ������ �� ���ѹ� ����Ǵ� �Լ� 
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }
    private void Start() //������Ʈ ���� ���� ���� �����ϴ� �Լ� //��������� �ʱ�ȭ ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    private void FixedUpdate() //�������� ������Ʈ //�������꿵�� ���� , ������ ���� �ֱ�� cpu�� ���� ��� 
    {
        Debug.Log("�̵�~");
    }
    private void Update() //���� ���� ������Ʈ , ȯ�濡 ���� ���� �ֱⰡ ������  �� ����
    {
        Debug.Log("���� ���!");
    }
    private void LateUpdate() //��� ������Ʈ ���� �� 
    {
        Debug.Log("����ġ ŉ��.");
    }
    private void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    private void OnDestroy() //���� ������Ʈ�� ������ ��
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
