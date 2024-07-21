using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class playercontroller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _fixedjoystick;
    //[SerializeField] private FloatingJoystick _fixedjoystick;
    [SerializeField] private float _movespeed = 6;

    private Vector3 vector; 

    private void Update()
    {
        vector = new Vector3(_fixedjoystick.Horizontal * _movespeed, _rigidbody.velocity.y, _fixedjoystick.Vertical * _movespeed);
        _rigidbody.velocity = vector * -1;

        if (_fixedjoystick.Horizontal != 0 || _fixedjoystick.Vertical != 0)
        {
            transform.rotation=Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}
