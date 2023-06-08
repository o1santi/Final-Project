using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets; 
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public Button menuButton;

    void Start()
    {
       
    }
    public void StartGame() 
    { isGameActive = true;
}

    public void GameOver()
    {
    
    gameOverText.gameObject.SetActive(true);
    isGameActive = false;
    restartButton.gameObject.SetActive(true);
    menuButton.gameObject.SetActive(true);

    }
    

    

    void Update()
    {
        
    }
    
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
