using UnityEngine;

public class FogSpawn : MonoBehaviour
{
    public GameObject trapItem;
    private bool isObjectActive = true;

    public float startTime = 0f;
    public float intervalTime = 10f;
    
    private void Start()
    {
        // Start the timer
        InvokeRepeating("TrapItem", startTime, intervalTime);
    }
    
    private void TrapItem()
    {
        // Toggle the object's active state
        trapItem.SetActive(isObjectActive);
        
        // Invert the active state for the next toggle
        isObjectActive = !isObjectActive;
    }
}
