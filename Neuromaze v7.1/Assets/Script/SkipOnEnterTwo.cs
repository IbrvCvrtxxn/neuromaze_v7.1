using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipOnEnterTwo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("ToChapterTwo");
        }
    }
}
