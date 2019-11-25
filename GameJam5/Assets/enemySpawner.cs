using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemySpawner : MonoBehaviour
{
    private float spawnRate;
    static public int enemyCount;
    public GameObject enemy;
    private bool spawnNextWave;
    private int totalSpawned;

    static public int waveNumber;
    [SerializeField]
    private float spawnWait;

    public Text waveText;
    public Text Score;
    static public int scoreNum;


    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 1;
        totalSpawned = 0;
        enemyCount = 0;
        spawnRate = 0.1f;
        spawnWait = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnWait >= 100)
        {
            if (enemyCount < waveNumber * waveNumber && totalSpawned < waveNumber * waveNumber)
            {
                spawn();
                totalSpawned++;
            }
        }
        if (enemyCount == 0 && totalSpawned == waveNumber*waveNumber)
        {
            waveNumber++;
            totalSpawned = 0;
            enemyCount = 0;
        }
        spawnWait += spawnRate * waveNumber;
        waveText.text = "WAVE: " + waveNumber;
        Score.text = "SCORE: " + scoreNum;
    }

    void spawn()
    {
        enemy.GetComponent<enemy>().speedVar *= waveNumber/2;
        Instantiate(enemy, transform.position, Quaternion.Euler(0, 0, 0));
        enemyCount++;
        spawnWait = 0;
    }
}
