using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    Player player;

    bool inactive = false;

    void Start()
    {
        player = FindFirstObjectByType<Player>();

    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ( inactive == false)
        {
            if (other.CompareTag("Sharp"))
            {
                player.AddScore();
                Destroy(gameObject);
            }
            if (other.CompareTag("Player") || other.CompareTag("Enemy"))
            {
                player.TakeDamage();
                Speed = 0;
                transform.parent = player.transform;
            }
            inactive = true;
        }
       
    } 




}
