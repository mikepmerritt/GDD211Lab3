using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : Enemy
{
    public GameObject Gun;
    public int ScrollSpeed; // for panning across screen

    // autoscroll across screen and delete if necessary
    public override void Update()
    {
        base.Update();
        Gun.transform.eulerAngles = new Vector3(0, 0, -Mathf.Atan2(FindObjectOfType<Player>().transform.position.x - transform.position.x, FindObjectOfType<Player>().transform.position.y - transform.position.y) * 180f / Mathf.PI - 90);
        transform.position += Vector3.left * ScrollSpeed * Time.deltaTime;
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
        }
    }
}
