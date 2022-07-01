using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private int timeInterval=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currentTime= (int) Time.time;
        if(currentTime%3==0){

            Debug.Log(""+timeInterval+" seconds have just passed");
            Debug.Log("time is"+currentTime);
        }
    }
}
