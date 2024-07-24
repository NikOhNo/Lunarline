using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private readonly PlayerController controller;

    public PlayerMovement(PlayerController controller)
    {
        this.controller = controller;
    }

    public void MovePlayer(Vector2 direction)
    {
        controller.Rigidbody2D.velocity = direction * controller.PlayerStats.MoveSpeed;
        controller.Animator.SetBool("Moving", direction != Vector2.zero);
        if (direction != Vector2.zero && Mathf.Abs(direction.x) > Mathf.Epsilon)
        {
            controller.SpriteRenderer.flipX = direction.x > Mathf.Epsilon;
        }
    }
}
