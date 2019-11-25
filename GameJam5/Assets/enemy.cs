using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float speedVar;
    // Start is called before the first frame update
    void Start()
    {
        speedVar = 0.05f;
        player = FindObjectOfType<RotatePlayer>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        Vector3 velocity = direction.normalized * speedVar * (enemySpawner.waveNumber / 2.0f);
        transform.position += velocity;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("fireball")) { enemySpawner.scoreNum += 100;enemySpawner.enemyCount--; Destroy(this.gameObject);}
    }
}
