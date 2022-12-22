using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
    public static int scoreCounter;
    public static int lastScore;
    // Start is called before the first frame update
    private void Awake()
    {
        scoreCounter = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle" && GameManager.gameHasEnded == false)
        {
         scoreCounter++;
         lastScore = scoreCounter;
         Destroy(other.gameObject);
        }

    }
}
