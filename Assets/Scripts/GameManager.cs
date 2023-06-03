using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LampButtonController LampButtonController;

    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(LampButtonController.allBright == true)
        {
            door.SetActive(false);
        }
    }
}
