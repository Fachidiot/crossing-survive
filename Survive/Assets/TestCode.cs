using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    [SerializeField] Material[] mtrList;
    [SerializeField] float curvature;

    void Start()
    {
        foreach (var mtr in mtrList)
        {
            mtr.SetFloat("Curvature", curvature);
        }
    }
}
