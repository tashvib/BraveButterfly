using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);  
    }
}

