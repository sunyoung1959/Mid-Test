using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    // 플레이어의 움직임을 제한하기 위해 불러온 스크립트
    public PlayerController playerCont;

    //범위 안에 존재하는지 확인하기 위한 변수
    private bool isInRange = false;

    // 해당하는 UI를 저장하기 위한 변수
    public GameObject stonePanel;
    

    // 현재 UI상태를 저장하기 위한 변수
    public bool isActive = false;
    

    // Start is called before the first frame update
    void Start()
    {
        stonePanel.SetActive(false);
    }

    void Update()
    {
        //UI가 보이지 않을 때 범위 안에서 X키를 누르면 isActive가 true가 되고 플레이어가 움직일 수 없으며 UI가 보이게 된다.
        if(!isActive && isInRange && Input.GetKeyDown(KeyCode.X))
        {
            playerCont.canMove = false;
            stonePanel.SetActive(true);
            isActive = true;
        }

        // UI가 보일 때 X키를 누르면, isActive가 false가 되고 플레이어가 움직일 수 있게 되며 UI가 보이지 않게 된다.
        else if(isActive && Input.GetKeyDown(KeyCode.X))
        {
            playerCont.canMove = true;
            stonePanel.SetActive(false);
            isActive = false;
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
