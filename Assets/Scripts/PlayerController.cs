using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class PlayerController : MonoBehaviour{
    public float speed=10;
    public TMP_Text timerText;
    public TMP_Text levelText;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public float timer=-1;
    // Start is called before the first frame update
    void Start(){
      rb=GetComponent<Rigidbody>();
      count=0;
      SetCountText();
    }
    void OnMove(InputValue movementValue){
        Vector2 movementVector=movementValue.Get<Vector2>();
        movementX=movementVector.x;
        movementY=movementVector.y;
    }
    void SetCountText(){
        timerText.text="Time:"+timer;
        if(count >=8){
        }
    }
     void Respawn(){
        transform.position=new Vector3(20,0.5f,0);
    }
    void Update(){
        if(timer>=0){
            timer += Time.deltaTime;
        }
    }
    void FixedUpdate(){
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }


    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Respawn")){
        Respawn();
        }else if(other.gameObject.CompareTag("Start")){
        timer++;
        }
    }
}