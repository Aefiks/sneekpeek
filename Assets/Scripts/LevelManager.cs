using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public float timeLeft = 90f;


    public GameObject timeCounter;
    public GameObject gameOverOverlay;


    void Start()
    {
        
    }


    void Update()
    {

        timeLeft -= Time.deltaTime;



        UpdateUI();
    }

    void UpdateUI()
    {


        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozosta³y czas:" + Mathf.Floor(timeLeft).ToString();


        if(timeLeft <= 0)
            gameOverOverlay.SetActive(true);
    }
    public void OnWin()
    {

        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Wygra³eœ!";

    }
    public void OnLose()
    {

        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Kamera ciê zobaczy³a!";
    }
}
