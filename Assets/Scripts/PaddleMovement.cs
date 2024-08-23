using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D leftPaddleRb;
    [SerializeField]
    private Rigidbody2D rightPaddleRb;

    [SerializeField] private float speed = 10f;

    void Update()
    {
        moveRightPaddle();
        moveLeftPaddle();
    }

    public void moveRightPaddle()
    {
        // Move paddle with up and down arrows
        float movementArrows = Input.GetAxis("VerticalArrows");
        rightPaddleRb.velocity = new Vector2(0, movementArrows * speed);
    }

    public void moveLeftPaddle()
    {
        // Move paddle with W and S
        float movement = Input.GetAxis("Vertical");
        leftPaddleRb.velocity = new Vector2(0, movement * speed);
    }
}
