using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
public class ClawControl : MonoBehaviour
{
    public bool ClawActive;
    public bool GameOn;
    public bool ClawMovePressed;
    public bool ClawDownPressed;
    public bool ClawUpPressed;
    public bool ClawGrabPressed;
    public bool ClawUsedThisTurn;
    public bool ClawDownThisTurn;
    public bool ClawUpThisTurn;
    public bool ClawGrabThisTurn;
    public bool ClawDownInput;
    public bool ClawUpInput;
    public bool ClawGrabInput;
    public int tokens;
    public MyButton ClawButton;
    public MyButton ClawDownButton;

    public MyButton ClawUpButton;
    public ClawAnimationScripts ClawAnimation;
    public Animator anim;
    Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

     public void Update()
    {
       if (!GameOn) return;
       {

        if (Keyboard.current.spaceKey.isPressed == true && ClawUsedThisTurn == false || ClawButton.buttonPressed == true && ClawUsedThisTurn == false)
        {
            ClawMovePressed = true;
            ClawUsedThisTurn = true;
            tokens =- 1;
            rb.AddRelativeForce(40,0,0);
        }

        if (Keyboard.current.sKey.isPressed == true && ClawMovePressed == true  && ClawDownThisTurn == false || ClawDownButton.buttonPressed == true && ClawMovePressed == true && ClawDownThisTurn == false)
        {   
            ClawDownPressed = true;
            ClawDownThisTurn = true;
            rb.AddRelativeForce(-40,-20,0);
            anim.SetTrigger("Action");
        }

        


        if (Keyboard.current.gKey.isPressed == true && ClawMovePressed == true && ClawDownThisTurn == true && ClawGrabThisTurn == false)
        {   
            anim.SetTrigger("Grab");
            ClawGrabThisTurn = true;
            ClawGrabPressed = true;
            // ClawMovePressed = false;
            // ClawDownPressed = false;
            // ClawUsedThisTurn = false;
            // ClawDownThisTurn = false;
            rb.linearVelocity = Vector3.zero;

        }

        if (Keyboard.current.wKey.isPressed == true && ClawMovePressed == true  && ClawDownThisTurn == true && ClawGrabThisTurn == true && ClawUpThisTurn == false || ClawUpButton.buttonPressed == true && ClawMovePressed == true && ClawDownThisTurn == true && ClawGrabThisTurn == true && ClawUpThisTurn == false)
        {   
             ClawUpPressed = true;
             ClawUpThisTurn = true;
            rb.AddRelativeForce(0,10,0);
         }
       }
    
    }
    public void ClawMoving()
    {
        if (ClawMovePressed == true && ClawUsedThisTurn == false)
        {
            rb.AddRelativeForce(20,0,0);
            ClawUsedThisTurn = true;
        }

    }

    public void ClawMoveDown()
    {
        if (ClawDownInput == true && ClawMovePressed == true && ClawDownThisTurn == false)
        {
            Debug.Log("Claw Down");
            rb.AddRelativeForce(-20,-20,0);
            ClawDownThisTurn = true;
            anim.SetTrigger("Action");
            
        }

    }

    public void ClawMoveUp()
     {
         if (ClawUpInput == true && ClawMovePressed == true && ClawDownThisTurn == true)
        {
            Debug.Log("Claw Up");
            rb.AddRelativeForce(0,10,0);
            ClawUpThisTurn = true;  
        }

    }

    // public void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Plushie"))
    //     {
    //         Debug.Log("Plushie Caught!");


    //     }
    // }

}

