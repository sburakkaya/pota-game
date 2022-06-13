using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.position += Vector3.down * speed/2 * Time.deltaTime;

    }

    public void MeteorDurum()
    {
        Debug.Log("Pota Yokedildi");
        Object.Destroy(gameObject, 0.1f);
    }

    public void MeteorHizlandirici()
    {
        speed += speed / 9;
    }

}
