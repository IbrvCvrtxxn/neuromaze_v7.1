using UnityEngine;

public class BoneFollow : MonoBehaviour
{
    public float bulletSpeed = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Apply damage to the player here

            // Destroy the bullet
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }
}
