
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
   private Animator animator;
    //private float lastClickTime;
 //   private float animationSpeed = 5.0f;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          //  float timeSinceLastClick = Time.time - lastClickTime;
          //  animationSpeed = Mathf.Clamp(1f / timeSinceLastClick, 1f, 10f);
            PlayAttackAnimation();
           // lastClickTime = Time.time;
            
        }
    }

    private void PlayAttackAnimation()
    {
        
            
      //      animator.SetFloat("AttackSpeed", animationSpeed);
        animator.SetTrigger("PlayAnimation");
            Debug.Log("First Animation Played");
        
    }
}
