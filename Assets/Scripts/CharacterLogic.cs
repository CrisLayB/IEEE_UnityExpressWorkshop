using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLogic : MonoBehaviour
{
    [SerializeField] private int _money;

    public void IncreaseMoney(int amount)
    {
        // _money = _money + amount; // 
        _money += amount;
        GameManager.Instance.UpdateCounterCoins(_money);
    }

    private void OnCollisionEnter(Collision other) 
    {
        print("Ya perdiste");
        GameManager.Instance.ShowPanelGameOver();
        Destroy(this.gameObject);
    }
}
