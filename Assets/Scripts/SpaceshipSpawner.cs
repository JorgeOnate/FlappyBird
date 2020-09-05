using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipSpawner : MonoBehaviour
{
    [SerializeField]public float maxTime = 0;
    private float _timer = 0;
    public GameObject spaceShip;
    
    [SerializeField]public float TopHeight = 0;
    [SerializeField]public float BottomHeight = 0;

    // This will create the spawning of the enemies
    
    void Start()
    {
        GameObject newspace = Instantiate(spaceShip);
        newspace.transform.position = transform.position + new Vector3(0, Random.Range(-BottomHeight,TopHeight),0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            GameObject newspace = Instantiate(spaceShip);
            newspace.transform.position = transform.position + new Vector3(0, Random.Range(-BottomHeight,TopHeight),0);
            
            Destroy(newspace,15);
            _timer = 0;

        }

        
        _timer += Time.deltaTime;
    }
    
    
    
}
