using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public float checkRad;
    public Transform checkPos;

    public float damage;

    public float TimetoAtk;
    [SerializeField]
    private float StartTime2Atk;
    
	// Use this for initialization
	void Start () {
        TimetoAtk = StartTime2Atk;
	}
	
	// Update is called once per frame
	void Update () {
		if(TimetoAtk <= 0)
        {

            TimetoAtk = StartTime2Atk;
        }
        else
        {
            TimetoAtk -= Time.deltaTime;
        }
	}
}
