using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YanmaBolgesi : MonoBehaviour
{
    public Top top;
    public GameManager managerGame;
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
        if(collision.gameObject.tag=="YanmaBolgesi")
        {
            Debug.Log("Hey");
            managerGame.UpdateDurum();
            top.TopYokEt();

        }

        if(collision.gameObject.tag=="Player")
        {           
            Debug.Log("Hey");
            managerGame.UpdateDurum();

        }

    }
}
