using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; //the exact place where the bullets originate from
    public float fireRate = 0.2f; //seconds between shots
    private float nextTimeFire = 0f;
    public ButtonControl shootButton;

    private void Start()
    {
        shootButton = Mouse.current.leftButton;
    }
    // Update is called once per frame
    void Update()
    {
        if (nextTimeFire > 0)
            nextTimeFire -= Time.deltaTime; 

        if (shootButton.isPressed && nextTimeFire <= 0)
        {
            Shoot();
            nextTimeFire = fireRate;
        }

    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
            return;

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
