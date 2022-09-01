using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnDelay = 2.0f;
    private bool spawnDogAllowed = true;
    private float timer;
    

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnDogAllowed)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            // Initialize the timer after key pressed
            timer = 0.0f;
            
            // Disable the dog spawning
            spawnDogAllowed = false;
        }
        
        // Activating the timer
        timer += Time.deltaTime;
        
        // Activate the dog spawning once the condition is true 
        if (timer >= spawnDelay)
        {
            spawnDogAllowed = true;
        }
    }
}
