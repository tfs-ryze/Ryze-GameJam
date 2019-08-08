using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAbilities : MonoBehaviour {

    public GameObject Shield;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool blueAbility = Input.GetKeyDown(KeyCode.Space);

        if (blueAbility)
        {
            Ability();
        }
		
       
	}
    void Ability()
    {
        GameObject myShield = (GameObject) Instantiate(Shield, transform.position, Quaternion.identity);
        Shield sheildScript = myShield.GetComponent<Shield>();
        sheildScript.Player = this.gameObject;

    }
}
