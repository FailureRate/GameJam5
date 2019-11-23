using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    [Header("Timer")]
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 4)
        {
            timer = 0.0f;
            this.gameObject.SetActive(false);
        }
    }
}
