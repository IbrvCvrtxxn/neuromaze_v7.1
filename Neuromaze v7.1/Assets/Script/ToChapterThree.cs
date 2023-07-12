using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToChapterThree : MonoBehaviour
{
    void OnEnable() 
    {
        SceneManager.LoadScene("ToChapterThree", LoadSceneMode.Single);
    }
}