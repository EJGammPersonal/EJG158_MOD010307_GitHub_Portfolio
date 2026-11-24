using UnityEngine;
using UnityEngine.InputSystem;

public class ClawHingeScript : MonoBehaviour
{
    public HingeJoint[] clawJoints;
    public float openVelocity = -10f;
    public float closeVelocity = 10f;
    public float motorPower = 10f;

    public bool closing = false;

    public void ClawState(bool closing)
    {
        Debug.Log("Bool Started");
        float targetVelocit = closing ? closeVelocity : openVelocity;
        foreach (var joint in clawJoints)
        {
            joint.useMotor = true;
            JointMotor motor = joint.motor;
            motor.targetVelocity = targetVelocit;
            motor.force = motorPower;
            joint.motor = motor;
            Debug.Log("Motor Applied");
        }
    }

    void Update()
    {
        if(Keyboard.current.spaceKey.isPressed == true)
        {
                    ClawState(true);
        }
        else
            ClawState(false);
    }
}
