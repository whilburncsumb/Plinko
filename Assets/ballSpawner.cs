using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    public Transform spawnTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("game start");
        Vector3 spawnPosition = spawnTransform.position;
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("checking spacebar");
        if (Input.GetKey(KeyCode.Space))
        {   
            // Debug.Log("space is pressed");
            Vector3 spawnPosition = spawnTransform.position;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
