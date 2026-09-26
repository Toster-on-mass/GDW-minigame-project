using UnityEngine;

public class KillFish : MonoBehaviour
{

    public bool active = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<FishJump>() && active)
        {
            Destroy(other.gameObject);
        }
    }
}
