using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    // [SerializeField]
    private float moveSpeed= 1;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }
}
