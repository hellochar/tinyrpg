using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItemOnCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            this.transform.SetParent(col.transform);
            Destroy(this.GetComponent<Rigidbody2D>());
            this.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(this.transform.Find("Particle System").gameObject);
            // this.transform.SetParent(col.transform, false);
        }
    }

}
