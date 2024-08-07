using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(MeshCollider))]

public class playercontroller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _fixedjoystick;
    //[SerializeField] private FloatingJoystick _fixedjoystick;
    [SerializeField] private float _movespeed = 6;
    private float speed = 0.0f;

    Animator animator;

    private void Start()
    {
        if (_rigidbody == null)
        {
            Debug.Log("RigidBody");
            _rigidbody = GetComponent<Rigidbody>();
        }

        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        if (_fixedjoystick == null)
        {
            Debug.Log("Joystick");
            _fixedjoystick = FindObjectOfType<FixedJoystick>();
            //_fixedjoystick = FindObjectOfType<FloatingJoystick>();
        }
    }

    private void Update()
    {
        if (_fixedjoystick != null && _rigidbody != null)
        {
            Vector3 vector = new Vector3(_fixedjoystick.Horizontal * _movespeed, _rigidbody.velocity.y, _fixedjoystick.Vertical * _movespeed);
            _rigidbody.velocity = vector * -1;

            bool isMoving = _fixedjoystick.Horizontal != 0 || _fixedjoystick.Vertical != 0;

            if (isMoving)
            {
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);

                speed += 0.05f;

                if (speed > 0.0f && speed < 1.0f)
                {
                    animator.SetBool("isWalking", true);
                }
                else if (speed >= 1.0f)
                {
                    animator.SetBool("isRunning", true);
                }
            }

            else
            {
                speed = 0.0f;
                animator.SetBool("isWalking", false);
                animator.SetBool("isRunning", false);
            }
        }

        else
        {
            Debug.LogError("FixedJoystick or Rigidbody is not assigned.");
        }
    }
}

