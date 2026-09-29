using UnityEngine;

public class NetCapture : MonoBehaviour
{

    public float distence = 1.0f;
    public Vector2 direction;
    public bool active = false;

    public BoxCollider attachedBoxCollider;

    void Start()
    {
        DeactivateNet();
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

    public void ActivateNet(Vector2 newDir)
    {
        direction = newDir;
        active = true;
        attachedBoxCollider.enabled = true;
    }
    public void DeactivateNet()
    {
        active = false;
        attachedBoxCollider.enabled = false;
    }
}
