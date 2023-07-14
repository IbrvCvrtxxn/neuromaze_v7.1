using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipOnEnter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("ToChapterOne");
        }
    }
}
