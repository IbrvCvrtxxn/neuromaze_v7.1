using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 4f;
    public float sprintSpeed = 6.5f;
    public float gravity = -15f;
    public float jumpHeight = 1f;
    private bool sprinting;
    private bool lerpCrouch;
    private float crouchTimer;
    private bool crouching;

    public CameraShake cameraShake;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded;

        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;

            if (crouching)
                controller.height = Mathf.Lerp(controller.height, 1, p);
            else
                controller.height = Mathf.Lerp(controller.height, 2, p);

            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint();
            StartCoroutine(cameraShake.Shake(.07f, .07f));
        }
        else
        {
            StopSprinting();
        }
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;

        moveDirection.x = input.x;
        moveDirection.z = input.y;

        float currentSpeed = sprinting ? sprintSpeed : speed;
        controller.Move(transform.TransformDirection(moveDirection) * currentSpeed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;

        if (isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
        }
    }

    public void Crouch()
    {
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }

    public void Sprint()
    {
        if (!sprinting)
        {
            sprinting = true;
            speed = sprintSpeed;
        }
    }

    public void StopSprinting()
    {
        if (sprinting)
        {
            sprinting = false;
            speed = 4f;
        }
    }
}