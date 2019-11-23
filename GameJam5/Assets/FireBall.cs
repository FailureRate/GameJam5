using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    [Header("Timer")]
    float timer = 0.0f;
    [SerializeField]
    [Header("TimeLimit")]
    float timeLimit = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeLimit)
        {
            timer = 0.0f;
            this.gameObject.SetActive(false);
        }
    }
}
