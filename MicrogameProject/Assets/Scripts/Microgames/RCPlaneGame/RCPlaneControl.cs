using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
public class RCPlaneControl : MicrogameBehaviour
{
    public float thrusterPower = 1;
    public float topSpeed = 20f;
    public float lift = 1f;

    public float turnSpeed = 0.05f;

    public float maxSpeed = 5f;
    public Slider thrustSlider;


    public bool speedActive;

    public bool GameOn;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       if (!GameOn) return;
       
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
            if (thrusterPower > topSpeed)
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxSpeed);

            else if(thrusterPower < topSpeed)
            rb.AddForce(transform.forward * thrusterPower);
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxSpeed);
            
        }

       // {
       //     transform.Rotate(new Vector3(-0.5f, 0, 0));
       // }
		


        // if (rb.linearVelocity.magnitude < topSpeed)
        // {
        //     rb.AddRelativeForce(new Vector3(0, 0, thrusterPower));
        // }
    }

    private void FixedUpdate()
    {
        if(thrusterPower <= topSpeed) 
            {
        
             }
    }

    public void ValueChangeCheck()
    {
        thrusterPower = thrustSlider.value;
        speedActive = true;
        
    }

    public void OnTriggerEnter(Collider RingCollision)
    {   
        
        if (RingCollision.gameObject.CompareTag("Low") || RingCollision.gameObject.CompareTag("Mid") || RingCollision.gameObject.CompareTag("High"))
        {
            Debug.Log("Collision Happened, Points Should be scored");
            Destroy(RingCollision.gameObject);

        }
    }

    
}
