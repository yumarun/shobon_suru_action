﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public void GoSelectoScene()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
