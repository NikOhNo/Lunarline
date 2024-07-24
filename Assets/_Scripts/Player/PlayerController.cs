using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;

    public Rigidbody2D Rigidbody2D { get; private set; }
    public Animator Animator { get; private set; }
    public SpriteRenderer SpriteRenderer { get; private set; }

    private PlayerInput playerInput;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        SpriteRenderer = GetComponentInChildren<SpriteRenderer>();

        playerInput = GetComponent<PlayerInput>();
        playerMovement = new(this);
    }

    public void OnMove(CallbackContext context)
    {
        playerMovement.MovePlayer(context.ReadValue<Vector2>());
    }
}
