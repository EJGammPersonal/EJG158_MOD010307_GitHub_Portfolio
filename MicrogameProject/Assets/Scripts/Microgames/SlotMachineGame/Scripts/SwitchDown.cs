using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
public class SwitchDown : MonoBehaviour
{
    public GameObject SlotOne;
    public GameObject SlotTwo;
    public GameObject SlotThree;
    public SlotMachine slotSpinResult;
    public void Update()
    {
        if (Mouse.current.leftButton.isPressed == true)
        {
            slotSpinResult.Switch = true;
        }
        
    }
}
