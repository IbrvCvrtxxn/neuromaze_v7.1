using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToChapterTwo : MonoBehaviour
{
    void OnEnable() 
    {
        SceneManager.LoadScene("ToChapterTwo", LoadSceneMode.Single);
    }
}