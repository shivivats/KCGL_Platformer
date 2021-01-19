using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPot : MonoBehaviour
{

    public int healAmount;

    public GameObject Player;

    public float flyDistance;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the distance between the health pot's position and 
        // the player's position is less than the fly distance
        if(Vector2.Distance(gameObject.transform.position, Player.transform.position) < flyDistance)
        {
            rb.position = Vector2.MoveTowards(gameObject.transform.position, Player.transform.position, 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the thing we collided with is the player
        if(collision.gameObject.tag=="Player")
        {
            // then we give player some health equal to "healAmount"
            collision.gameObject.GetComponent<PlayerHealth>().ModifyHealth(healAmount);
            
            // then we destroy the health pot
            Destroy(gameObject);
        }
    }
}
