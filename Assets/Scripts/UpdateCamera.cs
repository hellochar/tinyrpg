using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        Vector3 viewPos = cam.WorldToViewportPoint(this.transform.position);

        float camHeight = cam.orthographicSize * 2;
        float camWidth = camHeight * Screen.width / Screen.height;

        if (viewPos.x < 0)
        {
            cam.transform.position += new Vector3(-camWidth, 0);
        } else if (viewPos.x > 1)
        {
            cam.transform.position += new Vector3(camWidth, 0);
        } else if (viewPos.y < 0)
        {
            cam.transform.position += new Vector3(0, -camHeight);
        } else if (viewPos.y > 1)
        {
            cam.transform.position += new Vector3(0, camHeight);
        }
    }
}
