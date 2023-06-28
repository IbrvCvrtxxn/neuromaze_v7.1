// using UnityEngine;

// public class PushandAnimate : MonoBehaviour
// {


//     public Transform player;
//     public Transform spike;
//     public Transform endPoint; // New endpoint reference
//     public float movementSpeed = 5f;

//     private Animator playerBAnimator;
//     private bool isMoving;

//     private void Start()
//     {
//         playerBAnimator = spike.GetComponent<Animator>();
//         MovePlayerBToPlayerA();
//     }

//     private void Update()
//     {
//         // Optional: You can remove the Update() function if you don't need it for other purposes.
//     }

//     private void MovePlayerBToPlayerA()
//     {
//         if (!isMoving)
//         {
//             isMoving = true;

//             StartCoroutine(MoveCoroutine());
//         }
//     }

//     private System.Collections.IEnumerator MoveCoroutine()
//     {
//         playerBAnimator.SetBool("playanime", true);

//         Vector3 targetPosition = endPoint.position; // Use endpoint position as the target
//         Quaternion targetRotation = player.rotation;

//         while (Vector3.Distance(spike.position, targetPosition) > 0.1f)
//         {
//             spike.position = Vector3.MoveTowards(spike.position, targetPosition, movementSpeed * Time.deltaTime);
//             spike.rotation = Quaternion.RotateTowards(spike.rotation, targetRotation, movementSpeed * Time.deltaTime * 10f);

//             yield return null;
//         }

//         playerBAnimator.SetBool("playanime", false);

//         isMoving = false;
//     }
// }


using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public Transform player;
    public Transform spike;
    public Transform endPoint;
    public float movementSpeed = 5f;

    private Animator playerBAnimator;
    private bool isMoving;

    private void Start()
    {
        playerBAnimator = spike.GetComponent<Animator>();
        MovePlayerBToPlayerA();
        Destroy(gameObject, 5f); // Destroy the object after 5 seconds
    }

    private void Update()
    {
        // Optional: You can remove the Update() function if you don't need it for other purposes.
    }

    private void MovePlayerBToPlayerA()
    {
        if (!isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveCoroutine());
        }
    }

    private System.Collections.IEnumerator MoveCoroutine()
    {
        playerBAnimator.SetBool("playanime", true);

        Vector3 targetPosition = endPoint.position;
        Quaternion targetRotation = player.rotation;

        while (Vector3.Distance(spike.position, targetPosition) > 0.1f)
        {
            spike.position = Vector3.MoveTowards(spike.position, targetPosition, movementSpeed * Time.deltaTime);
            spike.rotation = Quaternion.RotateTowards(spike.rotation, targetRotation, movementSpeed * Time.deltaTime * 10f);

            yield return null;
        }

        playerBAnimator.SetBool("playanime", false);

        isMoving = false;
    }
}
