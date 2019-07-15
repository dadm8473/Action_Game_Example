using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAniManager : MonoBehaviour
{
    PlayerMove playerMove;
    PlayerAttack playerAttack;

    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    void Update()
    {
        
    }
}
