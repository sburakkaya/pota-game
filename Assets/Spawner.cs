using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Top TopScript;
    public GameObject Potalar;
    public GameObject Top;
    public float height;
    public float time;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnObject(float time)
    {
        while(!TopScript.gameOver)
        {
            
            Instantiate(Potalar,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.identity);

        
            yield return new WaitForSeconds(2.5f);
        }
        
    }
}