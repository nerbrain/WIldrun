using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Class instance for singleton pattern user
    public static GameController instance;
    public GameObject gameOverText; //used to display game over text 
    public bool gameOver= false;
    public float scrollSpeed= -2.0f; // determines scroll direction and you can override in UI
    private int score= 0;
    public Text scoreText;
    
    //called before start and used for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this){
            // Destory(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunnerScored(){
        if(gameOver){
            return;
        }
        score++;
        scoreText.text= "Score: " + score.ToString();
    }

// calls game over screen
    public void RunnerDied(){
        gameOverText.setActive(true);
        gamerOver= true;

    }
}
