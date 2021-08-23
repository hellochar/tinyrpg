using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //public bool hasSword = false;
    //public bool hasNecklace = false;
    //public bool hasCloak = false;

    public bool hasSword()
    {
        return this.transform.Find("Sword") != null;
    }

    public bool hasNecklace()
    {
        return this.transform.Find("Necklace") != null;
    }

    public bool hasShield()
    {
        return this.transform.Find("Shield") != null;
    }

    public bool hasAllItems()
    {
        return this.hasSword() && this.hasNecklace() && this.hasShield();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
