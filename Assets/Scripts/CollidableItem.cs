using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollidableItem : MonoBehaviour
{
    public int Health;
    public int Strength;
    

    // method for hitting player
    public virtual void Collide(Player player)
    {
        player.TakeDamage(Strength);
        TakeDamage(1);
    }

    // method for being hit by player
    public virtual void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
        if (Health <= 0)
        {
            DestroySelf();
        }
    }

    // kill this object
    public virtual void DestroySelf()
    {
        Destroy(this.gameObject);
    }

    // check for collisions
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collide(collision.gameObject.GetComponent<Player>());
        }
        else if (collision.gameObject.CompareTag("PlayerLaser"))
        {
            TakeDamage(collision.gameObject.GetComponent<PlayerLaser>().Strength);
            Destroy(collision.gameObject);
        }
    }
}
