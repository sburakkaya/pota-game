using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TersGiris : MonoBehaviour
{
    public GameObject Terso;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Ters Giriş");
            Instantiate(Terso,transform.position,Quaternion.identity);
            Time.timeScale = 0;
            

        }
    }

    

}
