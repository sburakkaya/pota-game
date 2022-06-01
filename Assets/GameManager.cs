using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public Text ScoreText2;
    public Text HighScore;
    public GameObject hell0;
    public GameObject hell1;
    public GameObject hell2;
    public GameObject hell3;
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

        StartCoroutine(ArkaPlan());

        if(score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore",score);
            HighScore.text = score.ToString();
        }

            
    }

    IEnumerator ArkaPlan()
    {
        if(score == 5 || score ==20 || score ==35 || score ==50)
        {
            hell3.SetActive(false);
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
        if(score == 10 || score ==25 || score ==40 || score ==55)
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
        if(score == 15 || score ==30 || score ==45 || score ==60)
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

    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
    }
}
