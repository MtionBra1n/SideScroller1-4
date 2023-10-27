using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class CharacterMovement : MonoBehaviour
{
    #region Private Variables
    /// <summary>
    /// Reference to the input actiom map file / Script
    /// </summary>
    private Player_InputActions inputActions;
    private InputAction moveAction;
    private InputAction rollAction;
    private InputAction attackAction;

    #endregion

    #region Public Variables
    public Vector2 moveInput;

    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spriteRenderer;

    #endregion

    #region Unity Event Functions
    private void Awake()
    {
        inputActions = new Player_InputActions();
        moveAction = inputActions.Player.Move;
        rollAction = inputActions.Player.Roll;
        attackAction = inputActions.Player.Attack;  
    }


    private void OnEnable()
    {
        inputActions.Enable();

        moveAction.performed += Move;
        moveAction.canceled += Move;

        attackAction.performed += Attack;
        rollAction.canceled += Roll;
    }

    private void Update()
    {        
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
    #endregion

    void Move(CallbackContext ctx)
    {
        moveInput = moveAction.ReadValue<Vector2>();

        if (ctx.performed)
        {
            print("WASD wurde gedrückt");
        }
        else
        {
            print("WASD wurde losgelassen");
        }
    }

    void Attack(CallbackContext ctx)
    {

    }

    void Roll(CallbackContext ctx)
    {

    }

}
