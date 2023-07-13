// using UnityEngine;

// public class ParticleDropper : MonoBehaviour
// {
//     public GameObject particlePrefab;

//     private void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.W))
//         {
//             DropParticle();
//         }
//     }

//     private void DropParticle()
//     {
//         GameObject particle = Instantiate(particlePrefab, transform.position, Quaternion.identity);

//         // Play the particle system
//         ParticleSystem particleSystem = particle.GetComponent<ParticleSystem>();
//         particleSystem.Play();
//     }
// }


using UnityEngine;

public class ParticleDropper : MonoBehaviour
{
    public GameObject particlePrefab; // Prefab of the particle system
    public float dropInterval = 0.5f; // Time interval between drops
    private bool isDropping = false; // Flag to check if dropping is in progress

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartDropping();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            StopDropping();
        }
    }

    private void StartDropping()
    {
        if (!isDropping)
        {
            isDropping = true;
            InvokeRepeating("DropParticle", 0f, dropInterval);
        }
    }

    private void StopDropping()
    {
        if (isDropping)
        {
            isDropping = false;
            CancelInvoke("DropParticle");
        }
    }

    private void DropParticle()
    {
        // Instantiate the particle system at the player's position
        GameObject particle = Instantiate(particlePrefab, transform.position, Quaternion.identity);

        // Play the particle system
        ParticleSystem particleSystem = particle.GetComponent<ParticleSystem>();
        particleSystem.Play();
    }
}
