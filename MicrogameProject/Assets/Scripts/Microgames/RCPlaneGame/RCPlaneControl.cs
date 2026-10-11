using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
public class RCPlaneControl : MicrogameBehaviour
{
    public float thrusterPower = 10f;
    public float topSpeed = 20f;
    public float lift = 1f;
    public Slider thrustSlider;

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
        // thrustSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});




        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddRelativeForce(0,1,0);
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
        thrusterPower = thrustSlider.value * topSpeed;
        rb.AddForce(Vector3.forward * thrusterPower);
    }
}
