using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public Transform firePoint;
    public KeyCode shoot = KeyCode.Space;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            Shoot();
        }        
    }
    void Shoot()
    {
        //Shooting logic
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }

}