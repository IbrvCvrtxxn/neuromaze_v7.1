using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrapSystem : MonoBehaviour
{
    public List<Transform> beatingPoints; // List of beating points
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float detectionRange = 10f;
    public float bulletInterval = 1f;
    private bool playerInRange = false;
    private Transform playerTransform;

    void Start()
    {
        InvokeRepeating("ThrowBullet", bulletInterval, bulletInterval);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            playerTransform = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            playerTransform = null;
        }
    }

    private void ThrowBullet()
    {
        if (playerInRange && playerTransform != null)
        {
            foreach (Transform point in beatingPoints)
            {
                var bullet = Instantiate(bulletPrefab, point.position, point.rotation);
                Vector3 direction = (playerTransform.position - point.position).normalized;
                bullet.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
            }
        }
    }
}
