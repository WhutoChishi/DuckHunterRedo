using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
   //public Timer time;

   

     public void GoToNextScene()
    {
            SceneManager.LoadScene(1);
    }
    public void GoToNextScene1()
    {
        SceneManager.LoadScene(0);
    }
}

