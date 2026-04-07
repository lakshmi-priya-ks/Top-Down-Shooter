using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage()
    {
        health--;
        Debug.Log("Health: " + health);

        if (health <= 0)
        {
            Debug.Log("GAME OVER");
            Invoke("RestartGame", 1.5f); // delay before restart
        }
    }

    void RestartGame()
    {
        Time.timeScale = 1; // reset time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}