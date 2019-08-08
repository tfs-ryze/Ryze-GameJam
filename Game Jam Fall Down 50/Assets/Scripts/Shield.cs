using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    public GameObject Player;
    private float timer;
    public float duration;
	// Use this for initialization
	void Start () {
        timer = duration;
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        transform.position = Player.transform.position;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
		
	}

}
