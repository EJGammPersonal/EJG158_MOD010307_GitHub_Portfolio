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
    public bool ClawUsedThisTurn;
    public bool ClawDownThisTurn;
    public bool ClawDownInput;
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

        if (Keyboard.current.sKey.isPressed == true && ClawMovePressed == true  && ClawDownThisTurn == false || ClawDownButton.buttonPressed == true && ClawMovePressed == true && ClawDownThisTurn == false)
        {   
            ClawDownPressed = true;
            ClawDownThisTurn = true;
            rb.AddRelativeForce(-20,-20,0);
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
            rb.AddRelativeForce(-20,-20,0);
            ClawDownThisTurn = true;
        }

    }

}

