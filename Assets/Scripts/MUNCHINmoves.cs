using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MUNCHINmoves : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator anims;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anims = GetComponent<Animator>();
    }
    
    private void OnMoves(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {
            anims.SetFloat("X", movement.x);
            anims.SetFloat("Y", movement.y);

            anims.SetBool("WalkActive", true);
        }
        else
        {
            anims.SetBool("WalkActive", false);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
