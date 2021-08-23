using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    public float tOffset = 0;
    private Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        this.initialPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        float deltaY = Mathf.Sin(time * 3f + this.tOffset) * 0.5f;
        this.transform.position = this.initialPos + new Vector3(0, deltaY);
    }
}
