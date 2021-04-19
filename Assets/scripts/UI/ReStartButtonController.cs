using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReStartButtonController : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("GameScene");
    }
}
