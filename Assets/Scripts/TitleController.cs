using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public string SceneToLoad;

    // 씬을 로드하는 코드
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
