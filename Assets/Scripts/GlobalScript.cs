using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static GlobalScript Instance;
    public int max_score = 5;
    public int scoreA, scoreB;
    void Start()
    {
       Instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScoreA(){
        scoreA++;
    }
    public void AddScoreB(){
        scoreB++;
    }
}
