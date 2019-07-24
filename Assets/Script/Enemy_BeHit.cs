using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_BeHit : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (animator.GetBool("BeHit") && 
            animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.BeHit") &&
            animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99f)
        {
            Debug.Log("false!!!");
            animator.SetBool("BeHit", false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            Debug.Log("HT!!!");
            animator.SetBool("BeHit", true);
        }
    }
}
