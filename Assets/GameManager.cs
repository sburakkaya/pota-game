using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TMP_Text ScoreText;
    public TMP_Text ScoreText2;
    public TMP_Text HighScore;
    public GameObject hell0,hell1,hell2,hell3,hell4,hell5,hell6,hell7,hell8;
    public Move move;
    public Move move2;
    public Move move3;

    
    // Start is called before the first frame update
    void Start()
    {

        score=0;
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
        ScoreText2.text = score.ToString();

        if(score==5 || score==10 || score==15|| score==20 || score==25 || score==30|| score==40 || score==50 || score==60 || score==70 || score==80 || score==90 || score==120 || score==150)
        {
            move.PotaHizlandirici();
            move2.PotaHizlandirici();
            move3.PotaHizlandirici();
        }

        StartCoroutine(ArkaPlan());

        if(score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore",score);
            HighScore.text = score.ToString();
        }

            
    }

    IEnumerator ArkaPlan()
    {
        if(score == 5)
        {
            hell8.SetActive(false);
            hell0.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell0.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell0.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell1.SetActive(true);
        }
        if(score == 10 )
        {
            hell1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell2.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell2.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell2.SetActive(true);
        }
        if(score == 15 )
        {
            hell2.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell2.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell2.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(true);
        }
        if(score == 20 )
        {
            hell3.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(true);
        }
        if(score == 20 )
        {
            hell3.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell3.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(true);
        }
        if(score == 25 )
        {
            hell4.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell5.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell5.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell4.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell5.SetActive(true);
        }
        if(score == 30 )
        {
            hell5.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell6.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell6.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell5.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell5.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell6.SetActive(true);
        }
        if(score == 35 )
        {
            hell6.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell7.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell7.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell6.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell6.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell7.SetActive(true);
        }
        if(score == 40 )
        {
            hell7.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell8.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell8.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell7.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            hell7.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            hell8.SetActive(true);
        }

    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
    }
}
