
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
   private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          PlayAttackAnimation();
        }
    }

    private void PlayAttackAnimation()
    {
      animator.SetTrigger("PlayAnimation"); 
    }
}
