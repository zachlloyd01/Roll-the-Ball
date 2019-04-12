using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject character;

    void Start()
    {
        rb = character.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.acceleration.x;
        float MoveVertical = Input.acceleration.y;
        Vector3 movement = new Vector3(MoveVertical, 0.0f, MoveHorizontal);
        rb.AddForce(movement);
    }
}
