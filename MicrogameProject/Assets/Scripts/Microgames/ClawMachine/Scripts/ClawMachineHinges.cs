using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Unity.VisualScripting;

public class ClawMachineHinges : MonoBehaviour
{
    
    [SerializeField] GameObject ClawRing;
   [SerializeField] GameObject ClawC;
   [SerializeField] GameObject ClawF;
   [SerializeField] GameObject ClawL;
   [SerializeField] GameObject ClawR;

   [SerializeField] float ClawVertical;
   [SerializeField] float ClawHorizontal;
   [SerializeField] float ClawArmMovementSpeed = 1.0f;
   [SerializeField] float ClawGripSpeed = 25.0f;
    private float maxgapdiff = 0.01f;

    const float maxarms = 0.5f;
    const float minarms = 0.5f;
    const float maxinput = 0.5f;
    const float mininput = 0.5f;

    [SerializeField] float closed = 10f;
    [SerializeField] float opened = -20f;
    [SerializeField] float forcewanted = 1.0f;
    [SerializeField] float forceBreaks = 200f;
    [SerializeField] float forceImpactReduction = 500f;

    private HingeJoint hingeClose;
    private HingeJoint hingeFar;
    private HingeJoint hingeLeft;
    private HingeJoint hingieRight;

    public void Awake()
    {
        
    }



}
