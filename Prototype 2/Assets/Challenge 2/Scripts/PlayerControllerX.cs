using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay;

    // Update is called once per frame
    void Update()
    {
        dogDelay += Time.deltaTime;
        // On spacebar press, send dog
        if (dogDelay > 1.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogDelay = 0;
            }
        }
    }
}
