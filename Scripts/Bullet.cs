using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet trigger hit: " + collision.name);

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Hit!");

            GameManager gm = FindFirstObjectByType<GameManager>();

            if (gm != null)
            {
                gm.AddScore(10);
            }
            else
            {
                Debug.Log("GameManager NOT FOUND!");
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}