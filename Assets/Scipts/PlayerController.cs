using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2d;
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D _rigidbody;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }
    }
    public void DisableControls(){
        canMove = false;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2d.speed = boostSpeed;
        }
        else{
            surfaceEffector2d.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddTorque(-torqueAmount);
        }
    }
}
