using UnityEngine;

public class NetCapture : MonoBehaviour
{

    public float distence = 1.0f;
    public Vector3 direction;
    public bool active = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (active)
        {
            transform.localPosition = direction * distence;
        }
        else
        {
            transform.localPosition = Vector3.zero;
        }
    }

    void ActivateNet(Vector3 newDir)
    {
        direction = newDir;
        active = true;
    }
    void DeactivateNet()
    {
        active = false;
    }
}
