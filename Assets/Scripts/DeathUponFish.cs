using UnityEngine;

public class DeathUponFish : MonoBehaviour
{

    public UImanager connectedIU;

    private void OnTriggerEnter(Collider other)
    {


        if (other.GetComponent<FishJump>())
        {
            connectedIU.SetButtonVisiblity(true);
            Destroy(gameObject);
        }
    }
}
