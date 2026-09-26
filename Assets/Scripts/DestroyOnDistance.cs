using UnityEngine;

public class DestroyOnDistance : MonoBehaviour
{
    public float destroyZ = -8.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
