using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacerock : CollidableItem
{
    public SpriteRenderer SR;
    public Sprite Damaged;
    public int ScrollSpeed; // for panning across screen

    // fully destroy if hit
    public override void Collide(Player player)
    {
        base.Collide(player);
        TakeDamage(1);
    }

    // change appearance when hit to a cracked sprite
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        if(Health < 2)
        {
            SR.sprite = Damaged;
        }
    }

    // autoscroll across screen and delete if necessary
    private void Update()
    {
        transform.position += Vector3.left * ScrollSpeed * Time.deltaTime;
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
        }
    }
}
