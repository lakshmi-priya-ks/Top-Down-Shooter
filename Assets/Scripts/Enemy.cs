using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Transform player;

    void Start()
    {
        // Find player
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (p != null)
        {
            player = p.transform;
        }
    }

    void Update()
    {
        // Move toward player
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy hit: " + collision.gameObject.name);


        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit!");

            PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();

            if (ph != null)
            {
                ph.TakeDamage();
            }
            else
            {
                Debug.Log("PlayerHealth NOT FOUND!");
            }

            Destroy(gameObject);
        }


        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Enemy Hit by Bullet!");

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