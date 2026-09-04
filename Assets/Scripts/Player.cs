using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float turnSpeed;

    public int score;   
    public int health;
    public TMP_Text scoreText;
    public TMP_Text healthText;
    void Start()
    {
        
    }


    void Update()
    {

        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }


    public void TakeDamage()
    {
        health--;
        healthText.text = "Health: " + health;
        if(health <= 0)
        {
            SceneManager.LoadScene("Game");
        }

    }

    public void AddScore()
    {
        score ++;
        scoreText.text = "Score: " + score;
    }
}
