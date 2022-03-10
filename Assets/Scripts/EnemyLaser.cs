using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : CollidableItem
{
    public Vector3 Direction;
    public static int Speed = 3;

    // set laser direction
    private void Awake()
    {
        Direction = Vector3.Normalize(FindObjectOfType<Player>().transform.position - transform.position);
        transform.eulerAngles = new Vector3(0, 0, -Mathf.Atan2(FindObjectOfType<Player>().transform.position.x - transform.position.x, FindObjectOfType<Player>().transform.position.y - transform.position.y) * 180f/ Mathf.PI - 90);
    }

    // move laser
    private void Update()
    {
        transform.position += Direction * Speed * Time.deltaTime;
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
        }
    }
}
