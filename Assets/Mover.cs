using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private double accumlatedTime=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        accumlatedTime += Time.deltaTime;
        transform.position=new Vector3((float)Math.Cos(accumlatedTime),0,(float)Math.Sin(accumlatedTime));

    }
}
