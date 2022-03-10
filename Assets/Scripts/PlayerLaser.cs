using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public int Strength;
    public static int Speed = 2;

    private void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;
        if (transform.position.x > 9)
        {
            Destroy(this.gameObject);
        }
    }
}
