using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButtonChapterThree : MonoBehaviour
{
    void Start() 
    {
        Cursor.visible = true;
    }


    public void SkipStoryline ()
    {
        SceneManager.LoadScene("ToChapterThree", LoadSceneMode.Single);
    }
    
}
