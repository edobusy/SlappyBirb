using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    public GameObject pipePrefab;

    private float timeRemaining = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            float randomHeight = Random.Range(-3f, 3f);
            Instantiate(pipePrefab, new Vector3(5, randomHeight, 0), Quaternion.identity);
            timeRemaining = 1.7f;
        }
    }
}
