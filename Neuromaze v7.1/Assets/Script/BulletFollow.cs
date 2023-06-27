// using UnityEngine;

// public class BulletFollow : MonoBehaviour
// {
//     public float bulletSpeed = 10f;
//     private Transform target;

//     public void SetTarget(Transform target)
//     {
//         this.target = target;
//     }

//     private void OnCollisionEnter(Collision collision)
//     {
//         if (collision.collider.CompareTag("Player"))
//         {
//             // Apply damage to the player here

//             // Destroy the bullet
//             Destroy(gameObject);
//         }
//     }

//     void Update()
//     {
//         if (target != null)
//         {
//             // Calculate the direction to the target
//             Vector3 direction = (target.position - transform.position).normalized;

//             // Rotate the bullet to face the target's position
//             Quaternion lookRotation = Quaternion.LookRotation(direction);
//             transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
//         }

//         // Move the bullet forward
//         transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
//     }
// }


using UnityEngine;

public class BulletFollow : MonoBehaviour
{
    public float bulletSpeed = 10f;
    private Transform target;
    private float destroyDelay = 1f;
    private float timer = 0f;

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Apply damage to the player here

            // Mark the bullet for destruction
            DestroyBullet();
        }
    }

    private void Update()
    {
        if (target != null)
        {
            // Calculate the direction to the target
            Vector3 direction = (target.position - transform.position).normalized;

            // Rotate the bullet to face the target's position
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
        }

        // Move the bullet forward
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        // Increment the timer
        timer += Time.deltaTime;

        // Destroy the bullet if necessary
        if (timer >= destroyDelay)
        {
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
