using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("ObjectHit: " + other.ToString());
        if (other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hitted";
        }
    }
  
}
