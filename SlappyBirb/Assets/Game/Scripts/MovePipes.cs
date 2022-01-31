using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public GameObject pipeUp;
    public GameObject pipeDown;
    Rigidbody2D pipeUpRigidbody;
    Rigidbody2D pipeDownRigidbody;
    float speed = 5f;
    private float timeRemaining = 4;

    // Start is called before the first frame update
    void Start()
    {
        pipeUpRigidbody = pipeUp.GetComponent<Rigidbody2D>();
        pipeDownRigidbody = pipeDown.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (new Vector3(-1, 0, 0) * (speed * Time.deltaTime));
        //pipeDown.transform.position = pipeDown.transform.position + (new Vector3(-1, 0, 0) * (speed * Time.deltaTime));

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Destroying " + this.name + "!!!!!!!");
            Object.Destroy(this.gameObject);
        }

    }
}
