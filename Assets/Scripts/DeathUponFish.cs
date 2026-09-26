using UnityEngine;

public class DeathUponFish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.GetType());

        if (other.GetComponent<FishJump>())
        {
            Destroy(gameObject);
        }
    }
}
