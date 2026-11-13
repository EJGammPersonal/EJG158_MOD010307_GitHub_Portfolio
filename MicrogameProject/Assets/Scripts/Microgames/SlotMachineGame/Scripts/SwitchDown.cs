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



    public SlotMachine SlotMachine;
    public void Update()
    {


        if (Keyboard.current.spaceKey.isPressed == true)
        {
            SlotMachine.SwitchUsed();
        }
    }
}
