// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class MainMenu : MonoBehaviour
// {
//     public void NewGame ()
//     {
//         SceneManager.LoadScene("MainStory");
        
//         Time.timeScale = 1f;
//         Cursor.visible = true;
//     }

//     public void LoadChapter ()
//     {
//         SceneManager.LoadScene("GameLevelOne");
        
//         Time.timeScale = 1f;
//         Cursor.visible = true;
//     }

//     public void QuitGame ()
//     {
//         Application.Quit();
//     }
    
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    int savedScene;
    int sceneIndex;

    public void NewGame ()
    {
        SceneManager.LoadScene("MainStory");
        
        Time.timeScale = 1f;
        Cursor.visible = true;
    }

    public void LoadChapter ()
    {
        savedScene = PlayerPrefs.GetInt("Saved");

        if(savedScene != 0)
            SceneManager.LoadSceneAsync(savedScene);
        else
            return;
        
        Time.timeScale = 1f;
        Cursor.visible = true;
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
    
}
