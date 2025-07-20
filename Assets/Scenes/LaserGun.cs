using UnityEngine;

public class LaserGun : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePoint;
    public float fireRate = 0.3f;
    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        // Add sound, light, or screen shake here if desired
    }
}
