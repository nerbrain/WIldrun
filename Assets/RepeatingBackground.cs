using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundVerticalLength;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider= GetComponent<BoxCollider2D>();
        groundVerticalLength= groundCollider.size.y;   
    }

    // Update is called once per frame
    void Update()
    {
        //check if it's time to repostion
        if(transform.position.y < -groundVerticalLength){
            RepostionBackground();
        }
    }

    // repositions the background
    private void RepostionBackground(){
        Vector2 groundOffset= new Vector2(0, groundVerticalLength * 15f);
        transform.position= (Vector2) transform.position + groundOffset;
    }
}
