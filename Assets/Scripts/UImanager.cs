using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{

    private Label scoreLabel;
    private Button resartButton;

    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        scoreLabel = root.Q<Label>("ScoreLabel");
        resartButton = root.Q<Button>("RestartButton");

        resartButton.clicked += () => RestartScene();

        SetButtonVisiblity(false);
    }

    public void UpdateScore(int newScore)
    {
        scoreLabel.text = (newScore.ToString());
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetButtonVisiblity(bool newVisible)
    {
        resartButton.visible = newVisible;
    }
}
