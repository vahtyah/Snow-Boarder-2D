using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float bostSpeed = 40;
    [SerializeField] float baseSpeed = 30;
    Rigidbody2D rb;
    SurfaceEffector2D effector;
    bool canMove = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        effector = FindObjectOfType<SurfaceEffector2D>();
    }
    private void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBost();
        }
        print(canMove);
    }

    public void DisableControls()
    {
        canMove = false;
    }

    private void RespondToBost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            effector.speed = bostSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            effector.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }
}
