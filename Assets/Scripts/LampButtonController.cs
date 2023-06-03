using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampButtonController : MonoBehaviour
{
    public LampController LampController;

    public bool buttonOn = false;

    private SpriteRenderer spriteRenderer;

    public bool allBright = false;

    // ��������Ʈ ��ü�� ���� �迭 ����
    public Sprite[] sprites;
    int sprite_index;

    // �÷��̾ ��ư ���� �ȿ� �����ϰ� �ִ��� Ȯ���ϱ� ���� ����
    public bool isInRange = false;

    // ������Ʈ���� ������ �����ϵ��� public���� ����
    // ��ư���� ��Ʈ���� �� �ִ� ������ �ٸ��� �ϱ� ����.

    public bool LampCont1 = false;
    public bool LampCont2 = false;
    public bool LampCont3 = false;
    public bool LampCont4 = false;
    public bool LampCont5 = false;
    public bool LampCont6 = false;

    // �ش� ������Ʈ���� ���ϱ� ���� ����
    public GameObject Lamp1;
    public GameObject Lamp2;
    public GameObject Lamp3;
    public GameObject Lamp4;
    public GameObject Lamp5;
    public GameObject Lamp6;

    // ���� ������Ʈ���� ������Ʈ LampController�� �����ϱ� ���� ����
    private LampController LampLight1;
    private LampController LampLight2;
    private LampController LampLight3;
    private LampController LampLight4;
    private LampController LampLight5;
    private LampController LampLight6;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        
        LampLight1 = Lamp1.GetComponent<LampController>();
        LampLight2 = Lamp2.GetComponent<LampController>();
        LampLight3 = Lamp3.GetComponent<LampController>();
        LampLight4 = Lamp4.GetComponent<LampController>();
        LampLight5 = Lamp5.GetComponent<LampController>();
        LampLight6 = Lamp6.GetComponent<LampController>();
    }


    
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.X))
        {
            if (buttonOn)
            {
                buttonOn = false;
            }
            else if (!buttonOn)
            {
                buttonOn = true;
            }

            // �� bool ���� true��� ���� ���� �� �� �ֵ��� �Ѵ�
            if (LampCont1)
            {
                LampLight1.LampLightSwitch();
            }
            if (LampCont2)
            {
                LampLight2.LampLightSwitch();
            }
            if (LampCont3)
            {
                LampLight3.LampLightSwitch();
            }
            if (LampCont4)
            {
                LampLight4.LampLightSwitch();
            }
            if (LampCont5)
            {
                LampLight5.LampLightSwitch();
            }
            if (LampCont6)
            {
                LampLight6.LampLightSwitch();
            }
        }

        // ��ư�� ��������Ʈ�� �ٲٱ� ���� �ڵ�
        if (!buttonOn)
        {
            sprite_index = 0;
            spriteRenderer.sprite = sprites[sprite_index];
        }
        else
        {
            sprite_index = 1;
            spriteRenderer.sprite = sprites[sprite_index];
        }

        //������ ��� ������ ��, allBright�� true�� 
        if(LampLight1.LampLight==true || LampLight2.LampLight == true|| LampLight3.LampLight == true|| LampLight4.LampLight == true|| LampLight5.LampLight == true|| LampLight6.LampLight == true)
        {
            allBright = true;
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
