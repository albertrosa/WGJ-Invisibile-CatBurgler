using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    
    public Countdown cloakTimer;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool hide = false;

    public bool cloak = false;

    public float runSpeed = 0f;    

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
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
            Debug.Log("Cloak Disabled");
            cloak = false;
        }
    }

    private void FixedUpdate()
    {
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
