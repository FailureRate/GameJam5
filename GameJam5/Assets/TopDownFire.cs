using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownFire : MonoBehaviour
{
    [SerializeField]
    [Header("BarrelTransform")]
    Transform barrel;
    [SerializeField]
    [Header("Bullet")]
    GameObject bullet;

    [SerializeField]
    [Header("ObjectPool")]
    ObjectPool pool;

    [SerializeField]
    [Header("BulletSpeed")]
    float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
       GameObject bullet_ = pool.SpawnObjectFromPool(barrel);
       Rigidbody2D rb = bullet_.GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.zero;
       rb.AddForce(barrel.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
