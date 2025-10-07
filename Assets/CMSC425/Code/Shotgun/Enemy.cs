using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Shooting Settings")]
    public GameObject bulletPrefab;      // Your bullet prefab
    public float shootCooldown = 2f;     // Seconds between shots
    public int bulletCount = 12;         // Number of bullets per spray
    public float spreadAngle = 60f;      // Cone angle

    private bool canShoot = true;


    void Update()
    {
        if (canShoot)
        {
            StartCoroutine(Shoot1());
        }
    }

    IEnumerator Shoot1()
    {
        canShoot = false;

        float angleStep = spreadAngle / (bulletCount - 1);
        float startAngle = -spreadAngle / 2f;

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = startAngle + angleStep * i;

            // Rotate around Y axis for horizontal spread
            Quaternion rotation = transform.rotation * Quaternion.Euler(0, angle, 0);

            Instantiate(bulletPrefab, transform.position, rotation);
        }

        yield return new WaitForSeconds(shootCooldown);
        canShoot = true;
    }
}
