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
    public bool canTakeDamage;
    // Start is called before the first frame update
    void Start()
    {
        canTakeDamage = true;
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
        if(other.gameObject.tag == "obstacle" && canTakeDamage)
        {
            Debug.Log("You took damage");
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            if (currentHealth == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            canTakeDamage = false;
            StartCoroutine(Cooldown());

        }
        else
        {
            Debug.Log("Currently on cooldown, damage will not be registered!");
        }
    }
    public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(2f);
        canTakeDamage = true;
    }
}
