using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
   

    // Start is called before the first frame update
    void Start()
    {
         //player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //Destroy(gameObject)
    }

    public void PotaDurum()
    {
        Debug.Log("Pota Yokedildi");
        Object.Destroy(gameObject,0.2f);
    }
}
