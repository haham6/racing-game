using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int gas = 100;
    public static int GameSpeed = 25;
    public string EndScene;
    
    public TMP_Text text;
    
    void Start()
    {
        gas = 100;
        InvokeRepeating("Decrease", 1f, 1f);
    }

    void Update()
    {
        text.text = gas.ToString();
    }
    
    void Decrease()
    {
        gas -= 10; // 숫자 10 감소

        // 숫자가 0보다 작아지면 호출 중지
        if (gas <= 0)
        {
            CancelInvoke("Decrease");
            SceneManager.LoadScene(EndScene);
        }
    }
}
