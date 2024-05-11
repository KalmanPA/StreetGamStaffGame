using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    Rigidbody _body;

    public float MaxRandomForceValue, StartRollingForce;

    float forceX, forceY, forceZ;

    public int diceFaceNum;

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        if (_body != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RollDice();
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                RollWinDice();
            }
        }
    }

    private void RollWinDice()
    {
        _body.isKinematic = false;

        //forceX = UnityEngine.Random.Range(0, MaxRandomForceValue);
        //forceY = UnityEngine.Random.Range(0, MaxRandomForceValue);
        //forceZ = UnityEngine.Random.Range(0, MaxRandomForceValue);

        //_body.AddForce(Vector3.up * StartRollingForce);
        //_body.AddTorque(forceX, forceY, forceZ);

        transform.rotation = Quaternion.Euler(270f, 0f, 0f);


    }

    private void RollDice()
    {
        _body.isKinematic = false;

        forceX = UnityEngine.Random.Range(0, MaxRandomForceValue);
        forceY = UnityEngine.Random.Range(0, MaxRandomForceValue);
        forceZ = UnityEngine.Random.Range(0, MaxRandomForceValue);

        _body.AddForce(Vector3.up * StartRollingForce);
        _body.AddTorque(forceX, forceY, forceZ);
    }

    private void Initialize()
    {
        _body = GetComponent<Rigidbody>();
        _body.isKinematic = true;
        transform.rotation = new Quaternion(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), 0);
    }
}
