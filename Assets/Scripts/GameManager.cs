using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LampButtonController LampButtonController;

    public GameObject door;

    
    void Start()
    {
        door.SetActive(true);
    }

    
    void Update()
    {
        // 전등이 모두 켜지면 문이 사라지도록 하는 코드
        if(LampButtonController.allBright == true)
        {
            door.SetActive(false);
        }
    }
}
