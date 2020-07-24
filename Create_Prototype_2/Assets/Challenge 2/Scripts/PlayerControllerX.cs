using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireInterval = 1.0f;
    private float nextFire = 0.0f;
    

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = nextFire + fireInterval;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
