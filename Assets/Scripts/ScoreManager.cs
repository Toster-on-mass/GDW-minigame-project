using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public UImanager scoreUiManager;

    void ScoreUpdated()
    {
        scoreUiManager.UpdateScore(score);
    }

    public void AddScore(int amount)
    {
        score += amount;
        ScoreUpdated();
    }

    public void ResetScore()
    {
        score = 0;
        ScoreUpdated();
    }

}
