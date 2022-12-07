using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxManager : MonoBehaviour
{
    public float skyboxSpeed;
    public Vector3 offset;

    void Start()
    {
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("Rotation", Time.deltaTime * skyboxSpeed);
    }
}
