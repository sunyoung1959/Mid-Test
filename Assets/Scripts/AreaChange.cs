using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaChange : MonoBehaviour
{
    public string areaToLoad;

    // collider≥¢∏Æ ¥Íæ“¿ª ∂ß, areaToLoad∑Œ æ¿¿ª ∑ŒµÂ«—¥Ÿ.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);
        }
    }
}
