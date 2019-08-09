using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

    public float Speed = 7;
    private float Screen_HalfWorldUnits;
	// Use this for initialization
	void Start () {
        float halfPlayerWidth = transform.localScale.x / 2f;
        Screen_HalfWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth; //Changes with resolution
		
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxisRaw ("Horizontal");
        float velocity = inputX * Speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if (transform.position.x < -Screen_HalfWorldUnits)
         {
            transform.position = new Vector2(Screen_HalfWorldUnits, transform.position.y);
        }
        if (transform.position.x > Screen_HalfWorldUnits)
        {
            transform.position = new Vector2(-Screen_HalfWorldUnits, transform.position.y);
        }

        if (Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                if (transform.position.x < -Screen_HalfWorldUnits)
                {
                    transform.position = new Vector2(Screen_HalfWorldUnits, transform.position.y);
                }
                if (transform.position.x > Screen_HalfWorldUnits)
                {
                    transform.position = new Vector2(-Screen_HalfWorldUnits, transform.position.y);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D triggerCollision)
    {
        if (triggerCollision.tag == "Obstacle")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }



}
