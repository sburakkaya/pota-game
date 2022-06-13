using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed=1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

     
    }

    public void PotaDurum()
    {
        Debug.Log("Pota Yokedildi");
        Object.Destroy(gameObject,0.1f);
    }

    public void PotaHizlandirici()
    {
        speed+=speed/9;
    }
}
