using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text healthText;
    public PlayerHealth player;

    void Update()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;

        if (healthText != null && player != null)
            healthText.text = "Health: " + player.health;
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }
}