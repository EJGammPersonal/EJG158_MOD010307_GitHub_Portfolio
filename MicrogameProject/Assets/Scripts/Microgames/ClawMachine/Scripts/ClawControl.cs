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
    public bool ClawUsedThisTurn;
    public int tokens;
    public MyButton ClawButton;
    public MyButton ClawDownButton;

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
            rb.AddRelativeForce(20,0,0);
        }

        if (Keyboard.current.sKey.isPressed == true && ClawMovePressed == true || ClawDownButton.buttonPressed == true && ClawMovePressed == true)
        {
            rb.AddRelativeForce(-20,-20,0);
        }

       }
    
    }
    public void ClawMoving()
    {
        if (ClawMovePressed == true)
        {
            rb.AddRelativeForce(20,0,0);
        }

    }

}

