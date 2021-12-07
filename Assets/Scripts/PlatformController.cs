using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformController : MonoBehaviour{
  float rise=2;
 // bool onMoveable=false;


    void Update(){
        transform.Translate(Vector3.up * Time.deltaTime * rise);
        if (transform.position.y>=2.1){ 
          rise=-2;
        }
        if(transform.position.y <= -1.99){
          rise=2;
      }
}
}
    
    /*  
    void Raise(){
    transform.Translate(Vector3.up*0.1f);
    rise=2;
  }
  private void OnTriggerEnter(Collider other){
    if(other.gameObject.CompareTag("Player")){
         onMoveable=true;
         }
    }
*/