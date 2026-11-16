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
    public bool PulledSwitch = false;
    public Animator anim;

    public SlotMachine SlotMachine;
    public SlotMachine2 SlotMachine2;
    public SlotMachine3 SlotMachine3;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Update()
    {


        if (Keyboard.current.spaceKey.isPressed == true && PulledSwitch == false)
        {
            anim.SetTrigger("Pull");
            SlotMachine.SwitchUsed();
            SlotMachine2.SwitchUsed();
            SlotMachine3.SwitchUsed();
            PulledSwitch = true;
        }
    }
}
