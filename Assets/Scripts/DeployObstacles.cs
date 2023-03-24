using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 startPosition = new Vector3(-1.3f, 0.316f, -29f);
    private int randomNum;

    public bool isReady = false;
    public List<GameObject> Obstacles = new List<GameObject>();
    public float speed = 10.0f;
    private GameObject obstaclePrefab;
    public float respawnTime = 2.0f;
    private void spawnObstacle()
    {
        randomNum = Random.Range(0 , Obstacles.Count);
        obstaclePrefab = Obstacles[randomNum];
        GameObject a = Instantiate(obstaclePrefab, startPosition, Quaternion.identity) as GameObject;
        rb = a.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);

    }

    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }
        
    }

    private void Update()
    {
        if(isReady)
        {
            StartCoroutine(obstacleWave());
            isReady = false;
        }
    }




}
