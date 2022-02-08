using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer;
    private float spamStopper = 1;

    void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        timer += Time.deltaTime;
        if (timer >= spamStopper)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                spawnDog();
                timer = 0;
            }
        }
    }
}
