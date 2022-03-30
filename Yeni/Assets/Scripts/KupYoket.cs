using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupYoket : MonoBehaviour
{
    public GameObject top;
    public GameObject kup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kupYoket();
    }
    void kupYoket()
    {
        if (kup.transform.position.z < top.transform.position.z - 3f)
        {
            Destroy(this.gameObject);
        }
        else
        {
            return;
        }
    }
}
