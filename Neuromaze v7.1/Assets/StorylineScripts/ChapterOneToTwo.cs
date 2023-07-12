using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterOneToTwo : MonoBehaviour
{
    void OnEnable() 
    {
        SceneManager.LoadScene("GameLevelTwo", LoadSceneMode.Single);
    }
}