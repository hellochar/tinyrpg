using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromKeyboard : MonoBehaviour
{
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 delta = new Vector2(horizontalInput, verticalInput);
        delta.Normalize();
        delta *= this.speed;
        //this.transform.position += delta;
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(delta);
    }
}
