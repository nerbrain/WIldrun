using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunner : MonoBehaviour
{

public Transform runner;
    
    // Update is called once per frame
    void Update()
    {
        transform.position=  new Vector3(0, 0, runner.position.y + 6);
    }
}
