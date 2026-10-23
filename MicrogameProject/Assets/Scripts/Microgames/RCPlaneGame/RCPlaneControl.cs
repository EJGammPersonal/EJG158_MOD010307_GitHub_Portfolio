using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
public class RCPlaneControl : MicrogameBehaviour
{
    public float thrusterPower = 1;
    public float topSpeed = 20f;
    public float lift = 1f;

    public float turnSpeed = 0.05f;

    public float maxSpeed = 5f;
    public Slider thrustSlider;

    public RCPlaneGame rCPlaneGame;
    public MyButton liftButton;
    public MyButton upButton;
    public MyButton downButton;
    public MyButton leftButton;
    public MyButton rightButton;


    public bool speedActive;

    public bool GameOn;
    Rigidbody rb;

   public bool liftPressed;
   public bool noseUpPressed;
    public bool noseDownPressed;
    public bool tiltLeftPressed;
    public bool tiltRightPressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
       if (!GameOn) return;
       
         thrustSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});


        if (Keyboard.current.spaceKey.isPressed || liftButton.buttonPressed == true)
        {
            //liftPressed = true;
           // if (liftPressed == true)
            //{
                rb.AddRelativeForce(0,2,0);
            //}
            // rb.AddRelativeForce(0,2,0);
        }

        if (Keyboard.current.wKey.isPressed || upButton.buttonPressed == true)
        {
           // noseUpPressed = true;
           // if (noseUpPressed == true)
           // {
            transform.Rotate(Vector3.left * turnSpeed);
            //}
        }

        if (Keyboard.current.sKey.isPressed || downButton.buttonPressed == true)
        {
            // //noseDownPressed = true;
            // if (noseDownPressed == true)
            // {
            transform.Rotate(Vector3.right * turnSpeed);
            //}
        }

        if (Keyboard.current.dKey.isPressed|| leftButton.buttonPressed == true)
        {
           // tiltLeftPressed = true;
           // if (tiltLeftPressed == true)
           // {
            transform.Rotate(Vector3.up * turnSpeed);
           // }
        }

        if (Keyboard.current.aKey.isPressed || rightButton.buttonPressed == true)
        {
            //tiltRightPressed = true;
            //if (tiltRightPressed == true)
           // {
            transform.Rotate(Vector3.down * turnSpeed);
           // }
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

    public void ValueChangeCheck()
    {
        thrusterPower = thrustSlider.value;
        speedActive = true;
        
    }

    public void OnTriggerEnter(Collider RingCollision)
    {   
        
        if (RingCollision.gameObject.CompareTag("Low"))
        {
            Debug.Log("Collision Happened, Points Should be scored");
            Destroy(RingCollision.gameObject);
            rCPlaneGame.pointsRemaining -= 1;
            Debug.Log("RingLow");
        }

        if (RingCollision.gameObject.CompareTag("Mid"))
        {
            Debug.Log("Collision Happened, Points Should be scored");
            Destroy(RingCollision.gameObject);
            rCPlaneGame.pointsLeft -= 3;
            Debug.Log("RingMid");
        }

        if (RingCollision.gameObject.CompareTag("High"))
        {
            Debug.Log("Collision Happened, Points Should be scored");
            Destroy(RingCollision.gameObject);
            rCPlaneGame.pointsLeft -= 5;
            rCPlaneGame.RingsCollected();
            Debug.Log("RingHigh");
        }
    }

    public void Up()
    {
         rb.AddRelativeForce(0,2,0);
    }

    public void noseUp()
    {
        transform.Rotate(Vector3.left * turnSpeed);
    }

    public void noseDown()
    { 
        transform.Rotate(Vector3.right * turnSpeed);      
    }

    public void left()
    {
        transform.Rotate(Vector3.up * turnSpeed);
    }

    public void right()
    {
        transform.Rotate(Vector3.down * turnSpeed);
    }
}