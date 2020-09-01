using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PipeMovement : MonoBehaviour
{
    
    [SerializeField]public float speed = 1;
    // This will be the movement of the pipes to the left of the screen
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
