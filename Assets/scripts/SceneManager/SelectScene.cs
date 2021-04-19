using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void GoStage1()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void returnStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
