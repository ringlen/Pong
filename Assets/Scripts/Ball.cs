using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 4f;
    private float speedIncrease = 0.25f;
    private int hitCounter = 0;

    private float timeMove = 1f;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartBall();
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
            Debug.Log("Hit counts: " + hitCounter);
        }
    }

    public void StartBall()
    {
        rb.velocity = new Vector2(1f, 1f).normalized * (speed + speedIncrease * hitCounter);
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        rb.transform.position = Vector2.zero;
        hitCounter = 0;
        Invoke("StartBall", timeMove);
    }

}
