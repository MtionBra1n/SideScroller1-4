using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    /// <summary>
    /// Reference to the input actiom map file / Script
    /// </summary>
    private Player_InputActions inputActions;
    private InputAction moveAction;

    public Vector2 moveInput;

    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        inputActions = new Player_InputActions();
        moveAction = inputActions.Player.Move;
    }


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void Update()
    { 
        moveInput = moveAction.ReadValue<Vector2>();

        if(moveInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(moveInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (moveInput.x != 0)
        {
            anim.SetFloat("MovementSpeed", 5);
        }
        else
        {
            anim.SetFloat("MovementSpeed", 0);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x * speed, rb.velocity.y);
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }


}
