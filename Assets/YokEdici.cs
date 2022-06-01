using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{

     public Move pota;
     public GameObject terso;
     public GameObject terso1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Debug.Log("Yokedildi");
            pota.PotaDurum();
            terso.SetActive(false);
            terso1.SetActive(false);
            Object.Destroy(gameObject);

        }
    }
}
