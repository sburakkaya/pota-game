using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DokunmaBaslatici : MonoBehaviour
{
    public GameObject BaslaticiDokunus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown (0))
        {
            Time.timeScale = 1;
            BaslaticiDokunus.SetActive(false);
            
        }
    }
}
