using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFX : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.position = TheCamera.Get().GetTargetPos();
        transform.rotation = Quaternion.LookRotation(TheCamera.Get().GetFacingFront(), Vector3.up);
    }
}