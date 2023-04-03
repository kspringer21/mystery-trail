using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour {

    public Transform player;
    private float time = 0.0f;
    private Vector3 offset;
    private float delay = 10f;

    void Start(){
        offset=transform.position-player.transform.position;
    }
    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if(time>=delay){
            time=0;
            Vector3 newPosition = player.transform.position + offset;
            transform.position = newPosition;
        }

    }
}
