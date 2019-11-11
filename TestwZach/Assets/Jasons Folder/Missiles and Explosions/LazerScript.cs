using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerScript : MonoBehaviour
{
    public float velX = 5f;
    //public int Damage;
    float velY = 0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velX, velY);
    }

    public GameObject explosion; // drag your explosion prefab here

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("BAM collision!!");
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject); // destroy the grenade
        Destroy(expl, 1); // delete the explosion after 3 seconds
    }
}
