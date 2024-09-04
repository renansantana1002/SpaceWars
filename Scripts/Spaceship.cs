using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public Projectile projectilePrefab;
    public float speed = 5f;
    void Update()
    {
        ApplyMoviment();
        FireProjectile();

    }

    void ApplyMoviment()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * speed * new Vector3(horizontal, vertical, 0));
    }

    void FireProjectile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
