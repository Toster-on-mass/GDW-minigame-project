using UnityEngine;
using UnityEngine.UIElements;

public class UImanager : MonoBehaviour
{

    private Label scoreLabel;

    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        scoreLabel = root.Q<Label>("ScoreLabel");
    }

    public void UpdateScore(int newScore)
    {
        scoreLabel.text = (newScore.ToString());
    }
}
