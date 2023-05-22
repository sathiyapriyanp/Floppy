using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        logic.GameOver();
        isAlive = false;
    }
}
