using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public sealed class SkaterController : MicrogameBehaviour
{
public float maxSpeed = 50f;
public float pushPower = 10f;
public float pushCooldown = 1f;
public float pushAccelerationDuration = 1f;
public float currentSpeed = 1f; 
private Rigidbody rb;


   public void SkateTap()
    {
        if (!isRunning) return;
        
        rb.AddForce(Vector3.forward * pushPower, ForceMode.Acceleration);


    }
}
