using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ResetTheGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     print("The button is working. ");   
    }
}