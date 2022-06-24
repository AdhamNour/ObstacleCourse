using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private double accumlatedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        accumlatedTime += Time.deltaTime;
        Vector3 HorizontalRotation = new Vector3((float)Math.Cos(accumlatedTime), 0, (float)Math.Sin(accumlatedTime));
        Vector3 VerticalRotation = new Vector3(0, 1+(float)Math.Cos(accumlatedTime), (float)Math.Sin(accumlatedTime));
        transform.position = HorizontalRotation + VerticalRotation;
    }
}