using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Timer : MonoBehaviour
{
    public float timeLeft = 5.0f;

    public Text startText;

    void Update()
    {
        timeLeft -= Time.deltaTime;

        startText.text = (timeLeft).ToString("0");

        if(timeLeft <= 0)
        {

        timeLeft = 0f;
        SceneManager.LoadScene(3);

        }

        
    }
    
}
