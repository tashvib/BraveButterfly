using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public float moveSpeed = 7f;
    //public SpriteRenderer player;
    public Rigidbody2D rb;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on the player object!");
        }
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = rb.position + (movement * moveSpeed)*Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.Space));

         // Retrieve input axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
         movement = new Vector2(horizontalInput, verticalInput);

        // Apply movement to the Rigidbody

    }
}
