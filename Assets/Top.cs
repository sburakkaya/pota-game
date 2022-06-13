using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Top : MonoBehaviour
{

    public GameManager managerGame;
    public bool gameOver = false;
    public int score = 0;
    public float velocity = 1f;
    public float forwardSpeed; 
    public Rigidbody2D rb2D; 
    public int combo =1;
    public float jumpForce;
    public float maxSpeed;
    public GameObject dethScreen;
    public Sprite sp1,sp2,sp3,sp4,sp5,sp6,sp7,sp8;
    public GameObject BaslaticiDokunus;

    public GameObject Patlama;

    public GameObject PauseButon;
    

    //public Text uiScore;
    bool didFlap = false;
    // Start is called before the first frame update

    

    void Start()
    {
        Time.timeScale = 0;
        BaslaticiDokunus.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        //uiScore.text = score.ToString();
        if (!gameOver) {
            if (Input.GetMouseButtonDown (0))
                didFlap = true;
                
        }

        if(managerGame.score == 5 || managerGame.score == 45)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if(managerGame.score == 10 || managerGame.score == 50)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if(managerGame.score == 15 || managerGame.score == 55)
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
        if(managerGame.score == 20 || managerGame.score == 60)
        {
            GetComponent<SpriteRenderer>().sprite = sp4;
        }
        if(managerGame.score == 25 || managerGame.score == 65)
        {
            GetComponent<SpriteRenderer>().sprite = sp5;
        }
        if(managerGame.score == 30 || managerGame.score == 70)
        {
            GetComponent<SpriteRenderer>().sprite = sp6;
        }
        if(managerGame.score == 35 || managerGame.score == 75)
        {
            GetComponent<SpriteRenderer>().sprite = sp7;
        }
        if(managerGame.score == 40 || managerGame.score == 80)
        {
            GetComponent<SpriteRenderer>().sprite = sp8;
        }

    }

    void FixedUpdate()//for movement
    {
        rb2D.AddForce (Vector2.right * forwardSpeed);
        rb2D.velocity = Vector3.ClampMagnitude(rb2D.velocity, maxSpeed);

        if (didFlap) {
            rb2D.velocity = new Vector2 (rb2D.velocity.x, Vector2.up.y * jumpForce);
            didFlap = false;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();

        }

        if(collision.gameObject.tag == "Terso")
        {
            managerGame.UpdateDurum();


        }

           
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
         if(other.gameObject.tag=="Patlama")
        {           
            Instantiate(Patlama,transform.position,Quaternion.identity);
            managerGame.UpdateDurum();

            Destroy(gameObject);
        }
    }

    public void TopYokEt() 
    {
        Destroy(gameObject,0.2f);
    }




    
  
    
}
