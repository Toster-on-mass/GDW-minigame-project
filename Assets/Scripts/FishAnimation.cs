using UnityEngine;

public class FishAnimation : MonoBehaviour
{
    public Rigidbody fishBody;
    public float gravityRotateMult = 11.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(fishBody.linearVelocity.y * gravityRotateMult, 180, 0);
        //Debug.Log(fishBody.linearVelocity.y);
    }
}
