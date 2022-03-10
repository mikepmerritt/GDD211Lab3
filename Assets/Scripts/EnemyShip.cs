using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Enemy
{
    public float Speed;

    public override void Update()
    {
        base.Update();
        transform.eulerAngles = new Vector3(0, 0, -Mathf.Atan2(FindObjectOfType<Player>().transform.position.x - transform.position.x, FindObjectOfType<Player>().transform.position.y - transform.position.y) * 180f / Mathf.PI - 90);
        transform.position += Vector3.Normalize(FindObjectOfType<Player>().transform.position - transform.position) * Speed * Time.deltaTime;
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
        }
    }
}
