using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public Text highscoreText;
    static public int scoreNum;
    static public bool playerdead = false;


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
        PlayerPrefs.SetInt("highscore", scoreNum);
        highscoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");

        if (playerdead) { SceneManager.LoadScene("gameOver", LoadSceneMode.Single); }
    }

    void spawn()
    {
        int decide = Random.Range(1,5);
        Vector3 pos = new Vector3();
        switch (decide)
        {
            case 1:
                pos.x = 9; pos.y = Random.Range(-9, 9);
                break;
            case 2:
                pos.x = -9; pos.y = Random.Range(-9, 9);
                break;
            case 3:
                pos.y = 9; pos.x = Random.Range(-9, 9);
                break;
            case 4:
                pos.y = -9; pos.x = Random.Range(-9, 9);
                break;
            case 5:
                pos.y = 9; pos.x = Random.Range(-9, 9);
                break;
        }
        enemy.GetComponent<enemy>().speedVar *= waveNumber/2;
        Instantiate(enemy, pos, Quaternion.Euler(0, 0, 0));
        enemyCount++;
        spawnWait = 0;
    }
}
