using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public bool LampLight = false;

    private SpriteRenderer spriteRenderer;

    // 켜지고 꺼지는 스프라이트 교체를 위한 배열 변수
    public Sprite[] sprites;
    int sprite_index;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!LampLight)
        {
            sprite_index = 0;
            spriteRenderer.sprite = sprites[sprite_index];
        }
        else
        {
            sprite_index = 1;
            spriteRenderer.sprite = sprites[sprite_index];
        }
    }

    // LampController의 LampLight가 true라면 false로, false라면 true로 바꾸는 함수.
    public void LampLightSwitch()
    {
        if (LampLight)
        {
            LampLight = false;
        }
        else
        {
            LampLight = true;
        }

    }

}
