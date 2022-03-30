using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject kup;
    public GameObject kaya;
    public Vector3 myVector;
    public Vector3 myVector2;
    public float uzaklik = 0;
    public float uzaklik2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("kayaSpawn", 1f, 1f);
        InvokeRepeating("kupSpawn", 2f, 3f);
    }

    // Update is called once per frame
    void kupSpawn()
    {
        uzaklik2 += 10f;
        myVector2 = new Vector3(Random.Range(10, -10), 0.5f, uzaklik2);
        Instantiate(kup, myVector2, Quaternion.identity);
    }

    void kayaSpawn()
    {
        uzaklik += 5f;
        myVector = new Vector3(Random.Range(-20, -10), 15f, uzaklik);
        Instantiate(kaya, myVector, Quaternion.identity);
    }

    

}
