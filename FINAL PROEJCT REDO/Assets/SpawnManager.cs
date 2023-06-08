using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; 
   public GameObject enemyPrefab1;
    public GameObject powerupPrefab;
    private float spawnRange = 10; 
    public int enemyCount; 
    public int waveNumber = 1; 
    public bool isGameActive;
    


    void Start()
    {
        while (isGameActive);
        SpawnEnemyWave(waveNumber);
        SpawnEnemyWave1(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), 
        powerupPrefab.transform.rotation); 
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length; 
        if (enemyCount ==0) { waveNumber++; SpawnEnemyWave(waveNumber); 
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);}
        if (enemyCount ==0) { waveNumber++; SpawnEnemyWave1(waveNumber); }
    }
        private Vector3 GenerateSpawnPosition () {
        float spawnPosX = Random.Range(-spawnRange, spawnRange); 
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return randomPos; } 

   
    void SpawnEnemyWave(int enemiesToSpawn) { 
    for (int i = 0; i < enemiesToSpawn; i++) {
    Instantiate(enemyPrefab, GenerateSpawnPosition(), 
    enemyPrefab.transform.rotation); } }

    void SpawnEnemyWave1(int enemiesToSpawn) { 
    for (int i = 0; i < enemiesToSpawn; i++) {
    Instantiate(enemyPrefab1, GenerateSpawnPosition(), 
    enemyPrefab1.transform.rotation); } }



}
