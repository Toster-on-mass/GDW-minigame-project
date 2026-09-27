using UnityEngine;

public class KillFish : MonoBehaviour
{

    public bool active = true;
    public ScoreManager killFishScoreManager;

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<FishJump>() && active)
        {
            killFishScoreManager.AddScore(1); // Reminder to make fish have score or somthing
            Destroy(other.gameObject);
        }
    }
}
