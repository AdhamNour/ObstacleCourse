using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float Speed = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime*Speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime*Speed;
        transform.Translate(xValue, 0, zValue);
    }
}