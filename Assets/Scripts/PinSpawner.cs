using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    private void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
