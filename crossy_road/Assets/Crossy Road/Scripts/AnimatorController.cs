using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public PlayerController PlayerController = null;
    private Animator animator = null;

    void Start()
    {
        animator = this.GetComponent<Animator>(); 
    }

    void Update()
    {
        if (PlayerController.isDead)
        {
            animator.SetBool("Dead", true); 
        }
        if (PlayerController.jumpStart) 
        {
            animator.SetBool("JumpStart", true); 
        }
        else if (PlayerController.isJumping)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
            animator.SetBool("JumpStart", false);
        }
        if (!PlayerController.isIdle) return;
        if (Input.GetKeyDown(KeyCode.UpArrow   )) { PlayerController.transform.rotation = Quaternion.Euler(0, 0, 0); }
        if (Input.GetKeyDown(KeyCode.DownArrow )) { PlayerController.transform.rotation = Quaternion.Euler(0, 180, 0); }
        if (Input.GetKeyDown(KeyCode.LeftArrow) ) { PlayerController.transform.rotation = Quaternion.Euler(0, -90, 0); }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { PlayerController.transform.rotation = Quaternion.Euler(0, 90, 0); }
    }

}
