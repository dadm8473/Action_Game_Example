using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;      // 플레이어 animator\

    void Start()
    {
        animator = GetComponent<Animator>();    // animator 받아오기
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) ||
            Input.GetKeyDown(KeyCode.I) ||
            Input.GetKeyDown(KeyCode.J) ||
            Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("isAttack", true);

            if (Input.GetKeyDown(KeyCode.U)) // L 펀
            {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
                {
                    if (animator.GetBool("Right_Attack2"))
                        animator.SetBool("Left_Attack3", true);
                    else if (animator.GetBool("Left_Attack2"))
                        animator.SetBool("Left_Attack3", true);
                    else if (animator.GetBool("Right_Down_Attack2"))
                        animator.SetBool("Left_Attack3", true);
                    else if (animator.GetBool("Left_Down_Attack2"))
                        animator.SetBool("Left_Attack3", true);

                    else if (animator.GetBool("Right_Attack1"))
                        animator.SetBool("Left_Attack2", true);
                    else if (animator.GetBool("Left_Attack1"))
                        animator.SetBool("Left_Attack2", true);
                    else if (animator.GetBool("Right_Down_Attack1"))
                        animator.SetBool("Left_Attack2", true);
                    else if (animator.GetBool("Left_Down_Attack1"))
                        animator.SetBool("Left_Attack2", true);
                }
                else
                    animator.SetBool("Left_Attack1", true);
            }
            if (Input.GetKeyDown(KeyCode.I)) // R 펀
            {
                if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
                {
                    if (animator.GetBool("Left_Attack2"))
                        animator.SetBool("Right_Attack3", true);
                    else if (animator.GetBool("Right_Attack2"))
                        animator.SetBool("Right_Attack3", true);
                    else if (animator.GetBool("Right_Down_Attack2"))
                        animator.SetBool("Right_Attack3", true);
                    else if (animator.GetBool("Left_Down_Attack2"))
                        animator.SetBool("Right_Attack3", true);

                    else if (animator.GetBool("Left_Attack1"))
                        animator.SetBool("Right_Attack2", true);
                    else if(animator.GetBool("Right_Attack1"))
                        animator.SetBool("Right_Attack2", true);
                    else if (animator.GetBool("Right_Down_Attack1"))
                        animator.SetBool("Right_Attack2", true);
                    else if (animator.GetBool("Left_Down_Attack1"))
                        animator.SetBool("Right_Attack2", true);
                }
                else
                    animator.SetBool("Right_Attack1", true);
            }
            if (Input.GetKeyDown(KeyCode.J)) // L 킥
            {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
                {
                    if (animator.GetBool("Right_Down_Attack2"))
                        animator.SetBool("Left_Down_Attack3", true);
                    else if (animator.GetBool("Left_Down_Attack2"))
                        animator.SetBool("Left_Down_Attack3", true);
                    else if (animator.GetBool("Left_Attack2"))
                        animator.SetBool("Left_Down_Attack3", true);
                    else if (animator.GetBool("Right_Attack2"))
                        animator.SetBool("Left_Down_Attack3", true);

                    else if (animator.GetBool("Right_Down_Attack1"))
                        animator.SetBool("Left_Down_Attack2", true);
                    else if (animator.GetBool("Left_Down_Attack1"))
                        animator.SetBool("Left_Down_Attack2", true);
                    else if (animator.GetBool("Left_Attack1"))
                        animator.SetBool("Left_Down_Attack2", true);
                    else if (animator.GetBool("Right_Attack1"))
                        animator.SetBool("Left_Down_Attack2", true);
                }
                else
                    animator.SetBool("Left_Down_Attack1", true);
            }
            if (Input.GetKeyDown(KeyCode.K)) // R 킥
            {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
                {
                    if (animator.GetBool("Left_Down_Attack2"))
                        animator.SetBool("Right_Down_Attack3", true);
                    else if (animator.GetBool("Right_Down_Attack2"))
                        animator.SetBool("Right_Down_Attack3", true);
                    else if (animator.GetBool("Left_Attack2"))
                        animator.SetBool("Right_Down_Attack3", true);
                    else if (animator.GetBool("Right_Attack2"))
                        animator.SetBool("Right_Down_Attack3", true);

                    else if (animator.GetBool("Left_Down_Attack1"))
                        animator.SetBool("Right_Down_Attack2", true);
                    else if (animator.GetBool("Right_Down_Attack1"))
                        animator.SetBool("Right_Down_Attack2", true);
                    else if (animator.GetBool("Left_Attack1"))
                        animator.SetBool("Right_Down_Attack2", true);
                    else if (animator.GetBool("Right_Attack1"))
                        animator.SetBool("Right_Down_Attack2", true);
                }
                else
                    animator.SetBool("Right_Down_Attack1", true);
            }
        }

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99f)
            AttackEnd();
    }

    void AttackEnd()
    {
        animator.SetBool("isAttack", false);

        animator.SetBool("Left_Attack1", false);
        animator.SetBool("Left_Attack2", false);
        animator.SetBool("Left_Attack3", false);

        animator.SetBool("Right_Attack1", false);
        animator.SetBool("Right_Attack2", false);
        animator.SetBool("Right_Attack3", false);

        animator.SetBool("Left_Down_Attack1", false);
        animator.SetBool("Left_Down_Attack2", false);
        animator.SetBool("Left_Down_Attack3", false);

        animator.SetBool("Right_Down_Attack1", false);
        animator.SetBool("Right_Down_Attack2", false);
        animator.SetBool("Right_Down_Attack3", false);
    }
}
