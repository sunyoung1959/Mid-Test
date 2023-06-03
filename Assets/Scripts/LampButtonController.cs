using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampButtonController : MonoBehaviour
{
    public LampController LampController;

    public bool buttonOn = false;

    private SpriteRenderer spriteRenderer;

    public bool allBright = false;

    // 스프라이트 교체를 위한 배열 변수
    public Sprite[] sprites;
    int sprite_index;

    // 플레이어가 버튼 범위 안에 접촉하고 있는지 확인하기 위한 변수
    public bool isInRange = false;

    // 오브젝트에서 조작이 가능하도록 public으로 선언
    // 버튼마다 컨트롤할 수 있는 램프를 다르게 하기 위함.

    public bool LampCont1 = false;
    public bool LampCont2 = false;
    public bool LampCont3 = false;
    public bool LampCont4 = false;
    public bool LampCont5 = false;
    public bool LampCont6 = false;

    // 해당 오브젝트들을 구하기 위한 변수
    public GameObject Lamp1;
    public GameObject Lamp2;
    public GameObject Lamp3;
    public GameObject Lamp4;
    public GameObject Lamp5;
    public GameObject Lamp6;

    // 구한 오브젝트들의 컴포넌트 LampController에 접근하기 위한 변수
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

            // 각 bool 값이 true라면 불을 끄고 켤 수 있도록 한다
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

        // 버튼의 스프라이트를 바꾸기 위한 코드
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

        //전등이 모두 켜졌을 때, allBright를 true로 
        if(LampLight1.LampLight==true || LampLight2.LampLight == true|| LampLight3.LampLight == true|| LampLight4.LampLight == true|| LampLight5.LampLight == true|| LampLight6.LampLight == true)
        {
            allBright = true;
        }
    }

    

    //플레이어가 콜라이더 범위 안으로 들어왔을 때 isInRange는 true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    //플레이어가 콜라이더 범위 밖으로 나갔을 때 isInRange는 false
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
