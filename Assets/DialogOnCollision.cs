using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnCollision : Dialog
{
    public string text;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            showDialog(this.gameObject, text, true);
        }
    }
}
