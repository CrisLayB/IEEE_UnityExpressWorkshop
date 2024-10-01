using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // print("HOLA MUNDO");
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // print("Me estoy ejecutando frame por frame");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed;
        characterController.SimpleMove(movement);
        // Documentacion Vector3: https://docs.unity3d.com/ScriptReference/Vector3.html
    }
}
