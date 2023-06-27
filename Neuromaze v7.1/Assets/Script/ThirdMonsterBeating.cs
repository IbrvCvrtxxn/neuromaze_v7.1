// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ThirdMonsterBeating : MonoBehaviour
// {
//     public Transform beatingPoint;
//     public GameObject bulletPrefab;
//     public float bulletSpeed = 10;
//     public float detectionRange = 10f;
//     public float bulletInterval = 1f; // Delay between bullet spawns

//     private bool playerInRange = false;

//     void Start()
//     {
//         // Start spawning bullets with the specified interval
//         InvokeRepeating("ThrowBullet", bulletInterval, bulletInterval);
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             playerInRange = true;
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             playerInRange = false;
//         }
//     }

//     private void ThrowBullet()
//     {
//         if (playerInRange)
//         {
//             var bullet = Instantiate(bulletPrefab, beatingPoint.position, beatingPoint.rotation);
//             bullet.GetComponent<Rigidbody>().velocity = beatingPoint.forward * bulletSpeed;
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdMonsterBeating : MonoBehaviour
{
    public Transform beatingPoint;
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
            var bullet = Instantiate(bulletPrefab, beatingPoint.position, beatingPoint.rotation);
            bullet.GetComponent<BulletFollow>().SetTarget(playerTransform);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        }
    }
}
