using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // transform.rotation = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        // https://docs.unity3d.com/ScriptReference/Quaternion.html
        transform.Rotate(
            0f,
            0f,
            Mathf.Sin(90) + _speed,
            Space.Self
        );
    }
}
