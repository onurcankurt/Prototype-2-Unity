using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        if (Input.GetKeyDown(KeyCode.Space) && Time.time - time > 1.5)
        {
            time = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
