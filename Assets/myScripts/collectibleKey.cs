using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleKey : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Inventory playerInventory = collision.gameObject.GetComponent<Inventory>();
            playerInventory.keyCount++;
            Destroy(gameObject);
        }
    }
}

