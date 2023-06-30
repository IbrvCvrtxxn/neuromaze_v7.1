using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TypingEffectText : MonoBehaviour
{
    public float typingSpeed = 0.05f;
    public string fullText;

    private Text textComponent;
    private string currentText = "";

    private Coroutine typingCoroutine;

    private void OnEnable()
    {
        textComponent = GetComponent<Text>();
        currentText = "";

        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }

        typingCoroutine = StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textComponent.text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
