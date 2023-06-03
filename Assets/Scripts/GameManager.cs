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
        // ������ ��� ������ ���� ��������� �ϴ� �ڵ�
        if(LampButtonController.allBright == true)
        {
            door.SetActive(false);
        }
    }
}
