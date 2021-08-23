using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnCollision : Dialog
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Inventory i = col.gameObject.GetComponent<Inventory>();
            if (i.hasAllItems())
            {
                SceneManager.LoadScene("GameWinScreen", LoadSceneMode.Single);
            } else
            {
                // Debug.Log("" + i.hasSword() + i.hasNecklace() + i.hasCloak());

                showDialog(this.gameObject, "Find the sword,\nnecklace, and shield!", true);
            }
        }
    }
}
