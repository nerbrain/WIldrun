using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize= 5;
    public GameObject columnPrefab;
    private GameObject[] columns;
    private float timeSinceLastSpawned;
    public float spawnRate= 4f;
    private Vector2 objectPoolPosition= new Vector2(-15f, 25f);
    public float columnMin= -1f;
    public float columnMax= 3.5f;
    private float spwanYPostion= 10f;
    private int currentColumn= 0;
    // Start is called before the first frame update
    void Start()
    {
        columns= new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i]= (GameObject) Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        //check if it's time to spawn new column
        if(GameController.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned= 0;
            float spwanXPosition= Random.Range (columnMin, columnMax);
            columns[currentColumn].transform.position= new Vector2(spwanXPosition, spwanYPostion);
            currentColumn++;

            if(currentColumn >= columnPoolSize){
                currentColumn= 0;
            }
        }
    }
}
