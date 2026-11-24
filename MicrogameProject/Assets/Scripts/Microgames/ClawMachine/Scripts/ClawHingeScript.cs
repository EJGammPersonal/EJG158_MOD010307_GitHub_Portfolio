using UnityEngine;
using UnityEngine.InputSystem;

public class ClawHingeScript : MonoBehaviour
{
    public HingeJoint[] clawJoints;
    public float openVelocity = -100f;
    public float closeVelocity = 100f;
    public float motorPower = 100f;

    public void ClawState(bool closed)
    {
        float targetVelocit = closed ? closeVelocity : openVelocity;
        foreach (var joint in clawJoints)
        {
            joint.useMotor = true;
            JointMotor motor = joint.motor;
            motor.targetVelocity = targetVelocit;
            motor.force = motorPower;
            joint.motor = motor;
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
