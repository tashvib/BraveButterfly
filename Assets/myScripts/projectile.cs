using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector2 direction = Vector2.right;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newPosition = rb.position + direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
   private void OnTriggerEnter2D(Collider2D collision)
  {
       if (collision.gameObject.tag != "Player")
       {
            
            //Debug.Log(collision.gameObject.name);
            Destructible destructibleobject = collision.gameObject.GetComponent<Destructible>();
            if(destructibleobject!= null)
            {
                destructibleobject.Damage(1);

            }
            Destroy(gameObject);
       }

    
    }
}