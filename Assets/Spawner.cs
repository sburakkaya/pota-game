using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Top TopScript;
    public GameManager managerGame;
    public GameObject Potalar;
    public GameObject CaprazPota;
    public GameObject HareketliPota;
    public GameObject DikPota;
    public GameObject Meteor;
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

            Instantiate(Potalar,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.identity);

        
            yield return new WaitForSeconds(2.5f);

            Instantiate(Potalar,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.identity);

            yield return new WaitForSeconds(3.5f);

            Instantiate(HareketliPota,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.Euler(0, 0, Random.Range(0, 30)));
            
            yield return new WaitForSeconds(3.5f);

            Instantiate(Potalar,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.identity);

        
            yield return new WaitForSeconds(3f);

            if (managerGame.score > 1)
            {
                Instantiate(Meteor, new Vector3(Top.transform.position.x + 14f, Random.Range(3, 7), 0), Quaternion.Euler(0, 0, Random.Range(0, 0)));


                yield return new WaitForSeconds(1f);
            }

            Instantiate(CaprazPota,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.Euler(0, 0, Random.Range(0, 30)));

        
            yield return new WaitForSeconds(3.5f);

            Instantiate(HareketliPota,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.Euler(0, 0, Random.Range(0, 30)));
            
        
            yield return new WaitForSeconds(3.5f);

            Instantiate(DikPota,new Vector3(Top.transform.position.x+10f,Random.Range(-height,height),0),Quaternion.Euler(0, 0, Random.Range(85, 90)));

        
            yield return new WaitForSeconds(2.5f);

            if (managerGame.score > 1) 
            {
                Instantiate(Meteor, new Vector3(Top.transform.position.x + 16f, Random.Range(4, 8), 0), Quaternion.Euler(0, 0, Random.Range(0, 0)));
                Instantiate(Meteor, new Vector3(Top.transform.position.x + 13f, Random.Range(2, 5), 0), Quaternion.Euler(0, 0, Random.Range(0, 0)));
                yield return new WaitForSeconds(2f);
            }
        }
        
    }
}
