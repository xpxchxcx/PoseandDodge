using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollider : MonoBehaviour
{
    public DetectObstacle detectObstacle;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle" && detectObstacle.canTakeDamage)
        {
            Debug.Log("You took damage");
            detectObstacle.currentHealth--;
            detectObstacle.healthBar.SetHealth(detectObstacle.currentHealth);
            if (detectObstacle.currentHealth == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            detectObstacle.canTakeDamage = false;
            detectObstacle.StartCoroutine(detectObstacle.Cooldown());

        }
        else
        {
            Debug.Log("Child Collider: Currently on cool down, no damage recorded");
        }
    }
}
