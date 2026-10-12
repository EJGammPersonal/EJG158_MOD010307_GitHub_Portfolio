using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
public class RCPlaneControl : MicrogameBehaviour
{
    public float thrusterPower = 1;
    public float topSpeed = 1;
    public float lift = 1f;

    public float turnSpeed = 0.05f;
    public Slider thrustSlider;

    public bool speedActive;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
       //if (!isRunning) return;
       //if (Input.GetKeyDown(KeyCode.W))
		// rb.AddForce(Vector3.forward * thrusterPower);
         thrustSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});




        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.AddRelativeForce(0,2,0);
        }

        if (Keyboard.current.wKey.isPressed)
        {
            transform.Rotate(Vector3.left * turnSpeed);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Rotate(Vector3.right * turnSpeed);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(Vector3.up * turnSpeed);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Vector3.down * turnSpeed);
        }

        if (speedActive == true)
        {
            rb.AddForce(Vector3.forward * thrusterPower);
        }

       // {
       //     transform.Rotate(new Vector3(-0.5f, 0, 0));
       // }
		


        // if (rb.linearVelocity.magnitude < topSpeed)
        // {
        //     rb.AddRelativeForce(new Vector3(0, 0, thrusterPower));
        // }
    }

    public void ValueChangeCheck()
    {
        thrusterPower = thrustSlider.value;
        speedActive = true;
        
    }

    
}
