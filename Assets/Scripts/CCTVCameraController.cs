using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    public float turnSpeed = 5f;

    public float turnAngle = 90;

    bool turningRight = !true;

    Transform cameraPosition;

    Transform cameraLens;



    void Start()
    {
        cameraPosition = transform.Find("CameraPosition");
        cameraLens = cameraPosition.Find("Cylinder");
    }

    void Update()
    {
        cameraPosition.localRotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9)*10-45, 0));

        CheckIfPlayerVisible();
    }

    void CheckIfPlayerVisible()
    {
        // Debug.DrawRay(cameraLens.position, cameraLens.TransformDirection(Vector3.down)*100, Color.yellow);
    }

}
