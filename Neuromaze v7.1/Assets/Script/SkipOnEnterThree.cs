using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipOnEnterThree : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("ToChapterThree");
        }
    }
}
