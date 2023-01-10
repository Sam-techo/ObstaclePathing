using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float horizontalInput;
    private float verticalInput;
    public bool isOnGround;
    [SerializeField]private float force = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal") * force;
        verticalInput = Input.GetAxis("Vertical") * force;

        playerRb.AddForce(horizontalInput, 0, verticalInput);
        
    }
}
