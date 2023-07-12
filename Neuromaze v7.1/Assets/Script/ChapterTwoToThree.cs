using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterTwoToThree : MonoBehaviour
{
    void OnEnable() 
    {
        SceneManager.LoadScene("GameLevelThree", LoadSceneMode.Single);
    }
}