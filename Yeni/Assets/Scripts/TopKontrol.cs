using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TopKontrol : MonoBehaviour
{
    public int puan;
    public int hiz;
    public int hizkat;
    public int objeSayisi;
    public Rigidbody fizik;

    public Text puanText;
    public Text oyunBittiText;

    public GameObject Kaya;


    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        
        if (Input.GetKey(KeyCode.Space))
        {
            hizkat = hiz * 2;
        }
        else {
            hizkat = hiz;
        }
        fizik.AddForce(vektor * hizkat);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        //Debug.Log("Sayaç =" + puan);
        puanText.text = "Puan: " + puan;


        if (puan == objeSayisi+10)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Space) == true & other.gameObject == Kaya.gameObject)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }

    


}
