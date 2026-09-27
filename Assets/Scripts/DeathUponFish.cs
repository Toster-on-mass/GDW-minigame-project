using UnityEngine;

public class DeathUponFish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {


        if (other.GetComponent<FishJump>())
        {
            Destroy(gameObject);
        }
    }
}
