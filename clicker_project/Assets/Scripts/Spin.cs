using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.WSA.Input;

public class Spin : MonoBehaviour
{
    private Rigidbody _body;
    private Quaternion _currentRotation;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _currentRotation = _body.rotation;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if (touch.phase.Equals(TouchPhase.Began))
            {
                Debug.Log("HELLO!");
                _body.AddRelativeTorque(0, 5, 0);
                _body.angularDrag = 0.05f;
            }

            if (touch.phase.Equals(TouchPhase.Ended))
            {
                Debug.Log("BYE!");
                _body.angularDrag = 1f;
            }
        }

    }

    
}
