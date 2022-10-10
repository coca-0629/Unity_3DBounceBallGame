using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject InvisibleBall;

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = speed * Time.deltaTime;

        if (Input.GetKey("w"))
            transform.Translate(Vector3.up * distance_per_frame);
        
        if (Input.GetKey("s"))
            transform.Translate(Vector3.down * distance_per_frame);

        if (Input.GetKey("a"))
            transform.RotateAround(InvisibleBall.transform.position, Vector3.up, 10 * distance_per_frame);

        if (Input.GetKey("d"))
            transform.RotateAround(InvisibleBall.transform.position, Vector3.down, 10 * distance_per_frame);

        if (Input.GetMouseButton(0))
            transform.Translate(Vector3.forward * distance_per_frame);
        
        if (Input.GetMouseButton(1))
            transform.Translate(Vector3.back * distance_per_frame);
    }
}
