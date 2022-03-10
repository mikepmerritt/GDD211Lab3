using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int Health;
    public GameObject Laser;
    public float Speed;
    public SpriteRenderer SR;
    public Sprite TwoHP, OneHP;

    public void TakeDamage(int damage)
    {
        if(damage > 0)
        {
            Health -= damage;
        }
        if(Health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else if (Health == 1)
        {
            SR.sprite = OneHP;
        } 
        else if (Health == 2)
        {
            SR.sprite = TwoHP;
        }
    }

    private void Update()
    {
        // shooting
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Laser, transform.position + (Vector3.right * 0.5f), Quaternion.identity);
        }

        // movement
        transform.position += Vector3.right * Speed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.position += Vector3.up * Speed * Input.GetAxisRaw("Vertical") * Time.deltaTime;
    }
}
