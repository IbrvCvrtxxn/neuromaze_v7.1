using UnityEngine;
using UnityEngine.UI;

public class CollectItemTrigger : MonoBehaviour
{
    public Canvas canvas;
    public float activationDuration = 5f;

    private bool isTriggered = false;
    private bool isCanvasActive = false;
    private float timer = 0f;

    private void Update()
    {
        if (isTriggered && isCanvasActive)
        {
            timer += Time.deltaTime;

            if (timer >= activationDuration)
            {
                DeactivateCanvas();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered && !isCanvasActive)
        {
            ActivateCanvas();
        }
    }

    private void ActivateCanvas()
    {
        isTriggered = true;
        isCanvasActive = true;
        canvas.gameObject.SetActive(true);
        timer = 0f;
    }

    private void DeactivateCanvas()
    {
        isCanvasActive = false;
        canvas.gameObject.SetActive(false);
    }
}