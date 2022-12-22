using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObstacle : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;
    public float outBoundsOne = -1.5f;
    public float outBoundsTwo = 3.6f;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
       if (target.transform.position.x < outBoundsOne || target.transform.position.x > outBoundsTwo)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "obstacle")
        {
            Debug.Log("You took damage");
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            if (currentHealth == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }

        }
    }
}
