using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = -10f;
    private const float Zero = 0f;

    public static Rotator Instance;
    private void Awake()
    {
        if(Instance != null)
            Instance = this;
    }

    private void FixedUpdate()
    {
        transform.Rotate(Zero, Zero, rotateSpeed * Time.deltaTime);    
    }
}
