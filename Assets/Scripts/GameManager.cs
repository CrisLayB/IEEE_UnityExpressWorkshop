using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Libreria para obtener y manulipar textos

public class GameManager : MonoBehaviour
{
    // Manager Component
    private static GameManager instance;
    public static GameManager Instance { get => instance; }

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }

        Destroy(gameObject);
    }    

    // Rest of logic
    [Header("UI Elements")]
    [SerializeField] private GameObject _panelVictory, _panelGameOver;
    [SerializeField] private TextMeshProUGUI _counterCoins;

    private void Start() 
    {
        UpdateCounterCoins(0);
    }

    public void ShowPanelVictory()
    {
        _panelVictory.gameObject.SetActive(true);
    }

    public void ShowPanelGameOver()
    {
        _panelGameOver.gameObject.SetActive(true);
    }

    public void UpdateCounterCoins(int coins)
    {
        _counterCoins.text = $"Coins: {coins}";
    }
}
