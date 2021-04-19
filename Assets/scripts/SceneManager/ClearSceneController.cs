using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearSceneController : MonoBehaviour
{
    public void GoSelectScene()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
