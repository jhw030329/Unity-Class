using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Action : MonoBehaviour
{
    public Animator animator;

    public void Jump_Attack()
    {
        animator.Play("Jump_Attack");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
