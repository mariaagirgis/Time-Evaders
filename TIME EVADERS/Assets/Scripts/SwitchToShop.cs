using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SwitchToShop : MonoBehaviour
{
    public TextMeshProUGUI moneytext;
    public int money = 0;
    public int beforeloadamt = 0;

    public void LoadShop()
    {
        if (moneytext.text.ToString() == "0")
        {
            SceneManager.LoadScene(3); // Second Scene
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            beforeloadamt += money;
            SceneManager.LoadScene(3);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}