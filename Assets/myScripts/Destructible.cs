using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 3;
    GameObject lootprefab;

    
    public void Damage(int amount)
    {
        health -=amount;
        if (health <= 0)

        {
            int lootChance = Random.Range(0, 3);
            if(lootChance == 0)
            {
                GameObject spawedLootPrefab = Instantiate(lootprefab);
                spawedLootPrefab.transform.position = transform.position;
            }
            Destroy(gameObject);
        }
    } 
}
