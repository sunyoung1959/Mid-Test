using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public bool LampLight = false;

    private SpriteRenderer spriteRenderer;

    // ������ ������ ��������Ʈ ��ü�� ���� �迭 ����
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

    // LampController�� LampLight�� true��� false��, false��� true�� �ٲٴ� �Լ�.
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
