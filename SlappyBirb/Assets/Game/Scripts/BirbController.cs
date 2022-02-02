using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbController : MonoBehaviour
{
    private Rigidbody2D rb;
    //private CircleCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //collider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Flap();
    }

    // The Birb is affected by gravity, so Flap will apply a force to the gameobject to launch it
    // Upwards a bit. This should happen every time SPACE is pressed.
    private void Flap ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Birb Flaps
            Debug.Log("SPACE is pressed");
            AudioManager.instance.Play("Flap");
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            GetComponent<Animator>().SetTrigger("Flap");
        }
    }
}
