using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heatBug;
    public Vector2 aim; // (x,y)
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bugProjectile();
        }

        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            aim.x = Input.GetAxisRaw("Horizontal");
            aim.y = Input.GetAxisRaw("Vertical");
        }
        


    }
        void bugProjectile()
    {
        GameObject projectileObject = Instantiate(heatBug);
        projectileObject.transform.position = transform.position;

        projectile projectileScript = projectileObject.GetComponent<projectile>();

        projectileScript.direction = aim.normalized;


    }
}
