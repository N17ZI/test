using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;
    public float speed = 2f;
    bool gameplay = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.velocity = new Vector2(Random.Range(2f, 4f) + speed, Random.Range(2f, 4f) + speed);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        rigidBody.velocity += new Vector2(Mathf.Clamp(speed, 3f, 5f), Mathf.Clamp(speed, 3f, 5f));
        if (col.gameObject.CompareTag("Lose")) { Debug.Log("Loser!"); gameplay = true; }
        if (col.gameObject.CompareTag("Block")) { Destroy(col.gameObject); }
    }
}
