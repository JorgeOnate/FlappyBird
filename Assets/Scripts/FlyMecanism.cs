using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FlyMecanism : MonoBehaviour
{
    //This Script simply controls the movement of the bird
    //in which case it only jumps
    // Start is called before the first frame update

    public GameManager gameManager;
   
    [Header("Velocity of flight:")]
    [Tooltip("This field is measured in units per second for the velocity")]
    [SerializeField] public float velocity = 1;
    
    //[Header("Jump Control:")]
    //[SerializeField] private KeyCode control;
    
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            _rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
