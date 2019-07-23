using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot_Collision_Detection : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = transform.root.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.6f)
            transform.root.SendMessage("Landing");
    }
}
