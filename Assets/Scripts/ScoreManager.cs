using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public int score=0;
    // Start is called before the first frame update
    public void IncrementScore()
    {
        score=score+5;
        ScoreText.text="Score:"+score;
        if(score==30)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
