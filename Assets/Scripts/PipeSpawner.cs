using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]public float maxTime = 0;
    private float _timer = 0;
    public GameObject pipe;

    //[SerializeField]public float height ;
    [SerializeField]public float TopHeight = 0;
    [SerializeField]public float BottomHeight = 0;
    
    // This will create the spawning of the pipes
    
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-BottomHeight,TopHeight),0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-BottomHeight,TopHeight),0);
            Destroy(newpipe,15);
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
