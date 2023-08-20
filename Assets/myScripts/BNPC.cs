using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNPC : MonoBehaviour
{
    SpriteRenderer srendere;
    Rigidbody2D rbody;
    Vector2 direction = Vector2.right;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        srendere = GetComponent<SpriteRenderer>();


        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 0)
        {
            direction = Vector2.up;
        }
        if (randomNumber == 1)
        {
            direction = Vector2.right;
        }
        if (randomNumber == 2)
        {
            Vector2 diagonalRight = new Vector2(1, 1);
            direction = diagonalRight;

        }
        if (randomNumber == 3)
        {
            Vector2 diagonalLeft = new Vector2(-1, 1);
            direction = diagonalLeft;



        }
        speed = Random.Range(1.5f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction.x > 0)
        {
            srendere.flipX = false;
        }
        if (direction.x < 0)
        {
            srendere.flipX = true;
        }
    }
    void FixedUpdate()
    {
        Vector2 newPosition = rbody.position + direction * speed * Time.fixedDeltaTime;
        rbody.MovePosition(newPosition);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;
    }
}
