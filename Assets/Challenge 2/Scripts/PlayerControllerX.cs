using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    //Create a time delay variable
    private float timeDelay = 0;

    // Update is called once per frame
    void Update()
    {
        //Increase Time delay after every second
        timeDelay += Time.deltaTime;

        // On spacebar press, send dog and if time is more that 2 seconds delay
        if (Input.GetKeyDown(KeyCode.Space) && timeDelay > 2  )
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeDelay = 0;
        }
    }
}
