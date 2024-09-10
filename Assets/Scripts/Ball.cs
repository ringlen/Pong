using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float initialSpeed = 4f;
    [SerializeField]
    private float speed = 4f;
    [SerializeField]
    private float speedIncrease = 0.1f;
    [HideInInspector]
    private int hitCounter = 0;

    private float timeMove = 1f;

    private Vector3 originalPos;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        originalPos = gameObject.transform.position;
        Invoke("StartBall", timeMove);
    }
    public void FixedUpdate()
    {
        speed += speedIncrease * hitCounter * Time.fixedDeltaTime;
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            hitCounter++;
            AudioManager.Instance.PlayPaddleHitAudion();
            Debug.Log("Hit counts: " + hitCounter);
        }
        if (collision.gameObject.tag == "TargetPlayer1")
        {
            GameManager.Instance.IncrementScorePlayer1();
            ResetBall();
            PaddleMovement.Instance.ResetPaddle();
            AudioManager.Instance.PlayScoreAudio();

            Debug.Log("Target1");
        }
        if (collision.gameObject.tag == "TargetPlayer2")
        {
            GameManager.Instance.IncrementScorePlayer2();
            ResetBall();
            PaddleMovement.Instance.ResetPaddle();
            AudioManager.Instance.PlayScoreAudio();

            Debug.Log("Target2");
        }
        if (collision.gameObject.tag == "Edge")
        {
            AudioManager.Instance.PlayBounceOfWallAudio();
        }
    }

    public void StartBall()
    { 
        rb.velocity = new Vector2(1f, 1f).normalized * initialSpeed;
    }

    public void ResetBall()
    {
        rb.transform.position = originalPos;
        rb.velocity = Vector3.zero;
        speed = initialSpeed;
        hitCounter = 0;

        Invoke("StartBall", timeMove);
    }

}
