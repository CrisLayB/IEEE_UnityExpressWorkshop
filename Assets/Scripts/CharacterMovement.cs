using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        // print("HOLA MUNDO");
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // print("Me estoy ejecutando frame por frame");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");        
        Vector3 movement = new Vector3(horizontal, 0, vertical) * _speed;

        if(movement.magnitude != 0) transform.forward = movement;

        _characterController.SimpleMove(movement);
        // Documentacion Vector3: https://docs.unity3d.com/ScriptReference/Vector3.html
    }
}
