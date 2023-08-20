using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textObject;
    
    void Start()
    {
        textObject.SetActive(false);
        textObject = gameObject.transform.GetChild(0).gameObject;

        /////////////////////
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            textObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            textObject.SetActive(false);
        }
    }

}
