using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }
}
