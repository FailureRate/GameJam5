using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    [SerializeField]
    [Header("Rigidbody")]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RotateUp()
    {
        rb.rotation = 0;
        
    }
    public void RotateRight()
    {
        rb.rotation = 270;
    }
    public void RotateLeft()
    {
        rb.rotation = 90;
    }
    public void RotateDown()
    {
        rb.rotation = 180;
    }
}
