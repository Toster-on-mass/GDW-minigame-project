using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 7.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
