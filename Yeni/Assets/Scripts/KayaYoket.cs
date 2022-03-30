using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayaYoket : MonoBehaviour
{
    public GameObject kaya;
    public GameObject top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        kayaYoket();
    }
    void kayaYoket()
    {
        if (kaya.transform.position.z < top.transform.position.z -3f)
        {
            Destroy(this.gameObject);
        }
        else
        {
            return;
        }
    }
}
