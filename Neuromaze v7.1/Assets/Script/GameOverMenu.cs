using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour

{

    int savedScene;
    int sceneIndex;
    
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", sceneIndex);
        PlayerPrefs.Save();
        SceneManager.LoadSceneAsync(0);
    }
}