using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot_Collision_Detection : MonoBehaviour
{
    public GameObject parent;

    void OnTriggerEnter(Collider col)
    {
        parent.SendMessage("Landing");
    }
}
