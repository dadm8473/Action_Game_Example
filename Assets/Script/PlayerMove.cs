using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;     // 플레이어 이동 속도

    Rigidbody rb;                   // 플레이어 rigidbody

    Animator animator;              // 플레이어 animator

    void Start()
    {
        rb = GetComponent<Rigidbody>();         // rigidbody 받아오기
        animator = GetComponent<Animator>();    // animator 받아오기
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            if (animator.GetBool("Back_Walk"))
                Back_Move_Stop();

            animator.SetBool("Forward_Walk", true);
        }

        if(Input.GetKey(KeyCode.A))
        {
            if (animator.GetBool("Forward_Walk"))
                Forward_Move_Stop();

            animator.SetBool("Back_Walk", true);
        }

        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            Move_Stop();

        if(Input.GetKeyDown(KeyCode.Space) && 
          (animator.GetCurrentAnimatorStateInfo(0).IsName("Idel") ||
           animator.GetCurrentAnimatorStateInfo(0).IsName("Back_Walk") ||
           animator.GetCurrentAnimatorStateInfo(0).IsName("Forward_Walk")))
        {
            animator.SetBool("Jump", true);
        }
    }

    void Forward_Move_Stop()
    {
        animator.SetBool("Forward_Walk", false);
    }

    void Back_Move_Stop()
    {
        animator.SetBool("Back_Walk", false);
    }

    void Move_Stop()
    {
        Forward_Move_Stop();
        Back_Move_Stop();
    }
}
