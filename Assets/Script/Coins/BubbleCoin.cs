using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Device;

public class BubbleCoin : MonoBehaviour
{
    

    private int bubble = 0;

    public TextMeshProUGUI bubleWalletText;
    public TextMeshProUGUI scoreEnd;

    public GameObject uiScene;
    public GameObject endScene;

    private void OnTriggerEnter(Collider u)
    {
        if (u.transform.tag == "Bubble")
        {
            bubble++;
            bubleWalletText.text = "Score :" + bubble.ToString();
            scoreEnd.text = "Score :" + bubble.ToString();
            Debug.Log(bubble);
            Destroy(u.gameObject);
            
        }
        if (u.transform.tag == "Goal")
        {
            OnPause();
            ShowSumUi();
        }
    }
    public void OnPause()
        {
            Time.timeScale = 0;
            ShowSumUi();
        }
    public void ShowSumUi()
    { 
        uiScene.SetActive(false);
        endScene.SetActive(true);
    }
    

}
