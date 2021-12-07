using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void LateUpdate(){
        transform.position =player.transform.position;
        transform.position+=Vector3.up*25;
        transform.position+=Vector3.back*5;
    }
}
