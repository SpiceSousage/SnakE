using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{   
    [SerializeField] private Rigidbody2D rb;

    void FixedUpdate()
    {
        PlayerMovement();       
    }
    private void PlayerMovement()
    {
        Vector2 moveDirection = new Vector2(0,0);

        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        float Movementspeed = 10f;

        moveDirection.Normalize();
        rb.velocity = moveDirection * Movementspeed;
    }
}
