using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject fallingObstaclePrefab;

    public Vector2 secondsBetweenSpawnsMinMax;
    private float nextSpawnTime;

    Vector2 screenHalfSize;

    public Vector2 spawnSizeMinMax;
    public float spawnAngleMax;



	// Use this for initialization
	void Start () {
        screenHalfSize = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);


    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent());
            nextSpawnTime = Time.time + secondsBetweenSpawns;
           

            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax); //Angle of the spawned items
            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            Vector2 SpawnPos = new Vector2(Random.Range(-screenHalfSize.x, screenHalfSize.x), screenHalfSize.y + spawnSize);
            GameObject newObstacle = (GameObject)Instantiate(fallingObstaclePrefab, SpawnPos, Quaternion.Euler(Vector3.forward * spawnAngle));
            newObstacle.transform.localScale = Vector2.one * spawnSize;
        }
		
	}
}
