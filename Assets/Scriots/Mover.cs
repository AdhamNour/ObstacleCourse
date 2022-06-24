using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private double accumlatedTime = 0;

    [SerializeField] private float HorizontalRadius = 1;

    [SerializeField] private float VerticalRadius = 1;
    [SerializeField] private double HorizontalSpeed = 1;
    [SerializeField] private double VirticalSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        accumlatedTime += Time.deltaTime;
        Vector3 HorizontalRotation = new Vector3(
            HorizontalRadius * (float)Math.Cos(accumlatedTime * HorizontalSpeed * Math.PI), 0,
            HorizontalRadius * (float)Math.Sin(accumlatedTime * HorizontalSpeed * Math.PI));
        Vector3 VerticalRotation = new Vector3(0,
            1 + VerticalRadius * (float)Math.Cos(accumlatedTime * VirticalSpeed * Math.PI),
            VerticalRadius * (float)Math.Sin(accumlatedTime * VirticalSpeed * Math.PI));
        transform.position = HorizontalRotation + VerticalRotation;
    }
}