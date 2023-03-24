using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateWave : MonoBehaviour
{
    public DeployObstacles deployObstacles;
    // Start is called before the first frame update
    public void StartWave()
    {
        deployObstacles.isReady = true;
    }
}
