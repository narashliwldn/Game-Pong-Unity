using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedY;
    public int directionY;
    public KeyCode btn_up, btn_down;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(btn_up)){
            directionY = 1;
        }
        else if(Input.GetKey(btn_down)){
            directionY = -1;
        }
        else{
            directionY = 0;
        }
        transform.Translate(0, speedY * directionY, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.62f, 3.51f), transform.position.z);
    }
}
