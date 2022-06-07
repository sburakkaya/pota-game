using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotaAlani : MonoBehaviour
{
    public Move pota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="PotaAlani")
        {
            pota.PotaDurum();
            Debug.Log("Fazla Pota Yokedildi");
        }
    }

}
