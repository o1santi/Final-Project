using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameManager gameManager;
    private Rigidbody playerRb;
    private float spawnRange = 10;
    public Button restartButton;
    public bool isGameActive;



    void Start()
    {
    playerRb = GetComponent<Rigidbody>();
    gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    void Update()
    {
        if (transform.position.y < -3)
    {
        Destroy(gameObject);
    if (!gameObject.CompareTag("Enemy")) { gameManager.GameOver();  }
    }}


    private Vector3 GenerateSpawnPosition () {
        float spawnPosX = Random.Range(-spawnRange, spawnRange); 
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 2, spawnPosZ);
        return randomPos; }


}
