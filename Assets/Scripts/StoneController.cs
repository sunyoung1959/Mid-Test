using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    // �÷��̾��� �������� �����ϱ� ���� �ҷ��� ��ũ��Ʈ
    public PlayerController playerCont;

    //���� �ȿ� �����ϴ��� Ȯ���ϱ� ���� ����
    private bool isInRange = false;

    // �ش��ϴ� UI�� �����ϱ� ���� ����
    public GameObject stonePanel;
    

    // ���� UI���¸� �����ϱ� ���� ����
    public bool isActive = false;
    

    // Start is called before the first frame update
    void Start()
    {
        stonePanel.SetActive(false);
    }

    void Update()
    {
        //UI�� ������ ���� �� ���� �ȿ��� XŰ�� ������ isActive�� true�� �ǰ� �÷��̾ ������ �� ������ UI�� ���̰� �ȴ�.
        if(!isActive && isInRange && Input.GetKeyDown(KeyCode.X))
        {
            playerCont.canMove = false;
            stonePanel.SetActive(true);
            isActive = true;
        }

        // UI�� ���� �� XŰ�� ������, isActive�� false�� �ǰ� �÷��̾ ������ �� �ְ� �Ǹ� UI�� ������ �ʰ� �ȴ�.
        else if(isActive && Input.GetKeyDown(KeyCode.X))
        {
            playerCont.canMove = true;
            stonePanel.SetActive(false);
            isActive = false;
        }
    }

    //�÷��̾ �ݶ��̴� ���� ������ ������ �� isInRange�� true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    //�÷��̾ �ݶ��̴� ���� ������ ������ �� isInRange�� false
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
