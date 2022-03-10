using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public float Cooldown;
    public float SpawnTimer;

    public GameObject Ship, Turret, Rock;

    public List<GameObject> Ships = new List<GameObject>();
    public List<GameObject> Turrets = new List<GameObject>();
    public List<GameObject> Rocks = new List<GameObject>();

    private void Start()
    {
        SpawnTimer = Cooldown;
    }

    private void Update()
    {
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer <= 0)
        {
            SpawnTimer = Cooldown;
            int roll = Random.Range(0, 10);
            // 0 - 6
            if(roll <= 6)
            {
                Rocks.Add(Instantiate(Rock, new Vector3(10f, Random.Range(-5f, 5f), 0), Quaternion.identity));
            }
            // 7 - 8
            else if (roll <= 8)
            {
                Turrets.Add(Instantiate(Turret, new Vector3(10f, Random.Range(-5f, 5f), 0), Quaternion.identity));
            }
            // 9
            else
            {
                Ships.Add(Instantiate(Ship, new Vector3(10f, Random.Range(-5f, 5f), 0), Quaternion.identity));
            }
        }
    }
}
