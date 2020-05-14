using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Countdown cloakTimer;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool cloak = false;
    public float runSpeed = 250f;
    public float cloakRunSpeed = .5f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        } 
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetButtonDown("Cloak"))
        {
            cloak = true;
        } else if (Input.GetButtonUp("Cloak"))
        {
            cloak = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }
    
    public void OnDeath()
    {
        animator.SetTrigger("IsDead");
    }

    private void FixedUpdate()
    {

        horizontalMove = cloak ? horizontalMove * cloakRunSpeed  : horizontalMove;        

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        if (cloak)
        {
            cloakTimer.startTimer();
        } else
        {
            cloakTimer.stopTimer();
        }
    }

}
