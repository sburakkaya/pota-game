using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsagiYukari : MonoBehaviour
{
    public float speed = 2f;
    public float height = 0.05f;
    //public float startY = 2f;
    float startY;
    // Start is called before the first frame update
    void Start()
    {
        startY = Random.Range(-1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var newY = startY + height*Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(pos.x, newY, pos.z);
    }
}
