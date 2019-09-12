using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedX, speedY;
    public int directionX, directionY;
    void Start()
    {
        directionX = Random.Range(0,2) > 0? 1:-1; //inline if
        /*
        if(Random.Range(0,2)>0){
            directionX = 1;
        }
        else{
            directionX = -1;
        }
         */
        directionY = Random.Range(0,2) > 0? 1:-1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX * directionX ,speedY *directionY ,0);
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "dinding_vertikal"){
            directionY *= -1;
        }

        if(other.gameObject.tag == "dinding_horizontal"){
            directionX *= -1;
        }
    }
}
