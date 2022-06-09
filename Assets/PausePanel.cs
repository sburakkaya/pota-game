using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PanelAc()
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
    }

    public void PanelKapa()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void EveDonus()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
