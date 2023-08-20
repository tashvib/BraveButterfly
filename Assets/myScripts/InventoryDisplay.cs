using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory playerInventory;
    public Text collectibleText;
    public Text keyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collectibleText.text = playerInventory.collectiblecount.ToString();
        keyText.text = playerInventory.keyCount.ToString();

    }
}
