using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaChange : MonoBehaviour
{
    public string areaToLoad;

    // collider���� ����� ��, areaToLoad�� ���� �ε��Ѵ�.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);
        }
    }
}
