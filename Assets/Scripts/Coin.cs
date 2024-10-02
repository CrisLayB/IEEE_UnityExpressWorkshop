using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _amount;

    private void OnTriggerEnter(Collider other) 
    {
        print("Personaje entro y su cantidad es: " + _amount);

        // tutorial normal de youtube
        // if(other.gameObject.tag == "Player")
        // {
        //     CharacterLogic player = other.gameObject.GetComponent<CharacterLogic>();
        //     player.IncreaseMoney(_amount);
        // }

        // Forma recomendada
        CharacterLogic player = other.gameObject.GetComponent<CharacterLogic>();

        if(player != null)
        {
            player.IncreaseMoney(_amount);
        }
        
        Destroy(this.gameObject);
    }

    // private void OnTriggerStay(Collider other) 
    // {
    //     print("Propiedad stay");
    // }

    // private void OnTriggerExit(Collider other) 
    // {
    //     print("Te saliste de la moneda");
    // }
}
