
using UnityEngine;

public class CollectObjectRotate : MonoBehaviour
{
    public float rotationSpeedX = 60f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeedX * Time.deltaTime);
    }
}
