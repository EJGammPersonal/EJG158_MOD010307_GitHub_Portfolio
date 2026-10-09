using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
public class RCPlaneControl : MicrogameBehaviour
{
    public float thrusterPower = 10f;
    public float topSpeed = 10f;

    public Slider thrustSlider;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void TakeOff()
    {
        if (!isRunning) return;
        if (Input.GetKeyDown(KeyCode.W))
		rb.AddForce(Vector3.forward * thrusterPower);

        thrustSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});
		
    }

    public void ValueChangeCheck()
    {
        thrusterPower = thrustSlider.value * topSpeed;
    }
}
