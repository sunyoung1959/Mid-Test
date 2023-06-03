using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D theRigid;
    public float moveSpeed;

    private Vector3 bottomLeftLimit;
    private Vector3 topRightLimit;

    public bool canMove = true;

    SpriteRenderer SpriteRenderer;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        theRigid = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            theRigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * moveSpeed;
        }
        else
        {
            theRigid.velocity = Vector2.zero;
        }

        // 스프라이트의 좌우를 바꾸기 위한 코드
        if (Input.GetButtonDown("Horizontal"))
        {
            SpriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }

        // 달리기 애니메이션을 바꾸기 위한 코드
        if (theRigid.velocity.normalized.x == 0)
        {
            anim.SetBool("isRun", false);
        }
        else
        {
            anim.SetBool("isRun", true);
        }

    }

    // 플레이어가 제한된 범위 외로 나가지 않게 하기 위한 함수
    public void SetBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottomLeftLimit = botLeft + new Vector3(0.5f, 1f, 0f);
        topRightLimit = topRight + new Vector3(-0.5f, -1f, 0f);
    }

}
