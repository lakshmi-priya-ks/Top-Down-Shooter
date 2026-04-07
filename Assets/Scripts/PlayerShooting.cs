using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    public float fireRate = 0.3f;
    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.up * bulletSpeed;

        // Ignore collision with player
        Physics2D.IgnoreCollision(
            bullet.GetComponent<Collider2D>(),
            GetComponent<Collider2D>()
        );
    }
}