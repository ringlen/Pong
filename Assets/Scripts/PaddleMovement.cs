using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D leftPaddleRb, rightPaddleRb;

    public static PaddleMovement Instance;

    private Vector3 leftPaddlePos, rightPaddlePos;

    [SerializeField] 
    private float speed = 10f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        leftPaddlePos = leftPaddleRb.transform.position;
        rightPaddlePos = rightPaddleRb.transform.position;

    }
    void Update()
    {
        MoveRightPaddle();
        MoveLeftPaddle();
    }

    public void MoveRightPaddle()
    {
        // Move paddle with up and down arrows
        float movementArrows = Input.GetAxis("VerticalArrows");
        rightPaddleRb.velocity = new Vector2(0, movementArrows * speed);
    }

    public void MoveLeftPaddle()
    {
        // Move paddle with W and S
        float movement = Input.GetAxis("Vertical");
        leftPaddleRb.velocity = new Vector2(0, movement * speed);
    }

    public void ResetPaddle()
    {
        leftPaddleRb.transform.position = leftPaddlePos;
        rightPaddleRb.transform.position = rightPaddlePos;
    }
}
