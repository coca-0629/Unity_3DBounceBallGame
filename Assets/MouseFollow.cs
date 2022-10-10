using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    float smooth = 5f;
    float tiltAngle = 30f;
    private Vector3 offset = new Vector3(0, -1, 4);

    // Update is called once per frame
    void Update()
    {
        float halfW = Screen.width/2f;
        float halfH = Screen.height/3f;

        transform.localPosition = new Vector3 ((Input.mousePosition.x - halfW)/halfW , 0, (Input.mousePosition.y - halfH)/halfH) + offset;
        //Debug.Log((Input.mousePosition.x - Screen.width/2)/(Screen.width/2));

        float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle * 2f;
        float tiltAroundX = Input.GetAxis("Mouse Y") * tiltAngle * -2f;

        var target = Quaternion.Euler(new Vector3(tiltAroundX, 0, tiltAroundZ));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);
    }
}
