using UnityEngine;

public class ClawAnimationScripts : MonoBehaviour
{
    public Animator anim;
    public bool clawDownAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clawDownAnimation == true)
        {
            anim.SetTrigger("Action");
            clawDownAnimation = false; 
         }
}
}