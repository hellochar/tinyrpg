using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public float speed = 5.0f;
    private bool touchStart = false;
    //private Vector2 pointA;
    //private Vector2 pointB;
    private Vector2 mousePointA;
    private Vector2 mousePointB;

    public Transform circle;
    public Transform outerCircle;

    public Vector2 pointA
    {
        get {
            return Camera.main.ScreenToWorldPoint(new Vector3(mousePointA.x, mousePointA.y, Camera.main.transform.position.z));
        }
    }
    public Vector2 pointB
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(mousePointB.x, mousePointB.y, Camera.main.transform.position.z));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePointA = Input.mousePosition;

            circle.transform.position = new Vector3(pointA.x, pointA.y, -1.0f);
            outerCircle.transform.position = new Vector3(pointA.x, pointA.y, -1.0f);
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            mousePointB = Input.mousePosition;
        }
        else
        {
            touchStart = false;
        }

    }
    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);

            circle.transform.position = new Vector3(pointA.x + direction.x, pointA.y + direction.y, -1.0f);
            outerCircle.transform.position = new Vector3(pointA.x, pointA.y, -1.0f);
        }
        else
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
    void moveCharacter(Vector2 direction)
    {
        // player.Translate(direction * speed * Time.deltaTime);
        this.transform.Translate(direction * speed * Time.deltaTime);
    }
}