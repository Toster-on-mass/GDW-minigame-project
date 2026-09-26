using System;
using Unity.VisualScripting;
using UnityEngine;

public class FishJump : MonoBehaviour
{

    public float jumpBoost = 10.0f;
    public Rigidbody body;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.GetComponent<FishJumpTrigger>())
        {
            body.AddForce(Vector3.up * jumpBoost, ForceMode.Impulse);
        }
    }
}
