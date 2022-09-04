using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnRandomBall", startDelay, SpawnInterval());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        
        //Invoke("SpawnRandomBall", Random.Range(3.0f, 5.0f));

        // Generate random ball index and random spawn position
        int ballIndex = (Random.Range(0, ballPrefabs.Length));
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        
    }

    // Spawn Interval of 3 to 5 seconds for the ball prefabs
     float SpawnInterval ()
    {
        return (Random.Range(3.0f,5.0f));
    }

}
