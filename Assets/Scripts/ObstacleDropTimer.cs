using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDropTimer : MonoBehaviour
{
    private Rigidbody obstacleRb;
    private MeshRenderer obstacleMr;
    private float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRb = GetComponent<Rigidbody>();
        obstacleMr = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            obstacleMr.enabled = true;
            obstacleRb.useGravity = true;
        }
    }
}
