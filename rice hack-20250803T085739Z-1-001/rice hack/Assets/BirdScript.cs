using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class testscript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength = 5;
    public GameLogicScript logic;
    public bool isAlive = true;
    public float moveSpeed = 5.0f;
    public AudioSource wingFlapSFX;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isAlive != true)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.P) == true && isAlive)
        {
            logic.Pause();
        }

        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            wingFlapSFX.Play();
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        
        
        if (transform.position.y < -6 || transform.position.y > 5.5)
        {
            logic.GameOver();
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        isAlive = false;
    }

}
