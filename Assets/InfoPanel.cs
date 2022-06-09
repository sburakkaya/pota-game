using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelAc()
    {
        Panel.SetActive(true);
    }

    public void PanelKapa()
    {
        Panel.SetActive(false);
    }

    public void WebSitesi()
    {
        Application.OpenURL("https://berayazilim.net/");
    }

    public void PlayStore()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=5845649875308092567&hl=tr&gl=US");
    }

}
