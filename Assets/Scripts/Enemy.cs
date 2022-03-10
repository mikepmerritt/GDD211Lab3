using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CollidableItem
{
    public GameObject Laser;
    public float Cooldown;
    public float FireTimer;

    private void Start()
    {
        FireTimer = Cooldown;
    }

    public bool CheckForFire()
    {
        return FireTimer <= 0;
    }

    public void TryFireLaser()
    {
        if(CheckForFire())
        {
            Instantiate(Laser, transform.position, Quaternion.identity);
            FireTimer = Cooldown;
        }
    }

    public virtual void Update()
    {
        TryFireLaser();
        FireTimer -= Time.deltaTime;
    }
}
