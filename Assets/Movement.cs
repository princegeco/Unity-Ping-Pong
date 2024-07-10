using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Left mouse button clicked");
            rigidBody.AddForce(0, 0, 500);
        }   

        if (Input.GetMouseButtonDown(1)){
            Debug.Log("Right mouse button clicked");
            rigidBody.AddForce(0, 0, -500);
        }
    }
}
