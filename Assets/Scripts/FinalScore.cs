using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public Text finalScoreText;
    private string storeText;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        storeText = ObjectHandler.scoreCounter.ToString("0");
        finalScoreText.text = storeText;
    }
}
