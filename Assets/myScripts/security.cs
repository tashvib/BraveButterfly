using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class security : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            Inventory playerInventory = collision.gameObject.GetComponent<Inventory>();
            if(playerInventory.keyCount>0)
            {
                Destroy(gameObject);
            }

        }
    }
}
