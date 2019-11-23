using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    [Header("Pool")]
    Queue<GameObject> pool;
    [SerializeField]
    [Header("Object")]
    GameObject objectPrefab;
    [SerializeField]
    [Header("PoolSize")]
    int size;
    [SerializeField]
    [Header("Instance")]
    ObjectPool instance;

    private int pointer = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        pool = new Queue<GameObject>();
        for(int i = 0; i < size; i++)
        {
            GameObject Prefab = Instantiate(objectPrefab);
            Prefab.SetActive(false);
            pool.Enqueue(Prefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SpawnObjectFromPool(Transform transform_)
    {
        GameObject foo = pool.Dequeue();
        foo.transform.position = transform_.position;
        foo.transform.rotation = transform_.rotation;
        foo.SetActive(true);
        pool.Enqueue(foo);
        return foo;
    }
}
