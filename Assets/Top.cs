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
    public GameObject Terso;
    public Sprite sp1,sp2,sp3;

    public GameObject BaslaticiDokunus;

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

        if(managerGame.score == 5)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if(managerGame.score == 10)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if(managerGame.score == 15)
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
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
            dethScreen.SetActive(true);
            
        }
           
    }



    public void UpdateDurum()
    {
        gameOver = true;
        Time.timeScale = 0;
        dethScreen.SetActive(true);
    }

    
    
}
