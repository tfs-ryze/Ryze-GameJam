using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{

    // public Vector2 speedMixMax; Speed Increase Variable
    public float Speed = 3;
    // Use this for initialization
    void Start()
    {
        // Speed = Mathf.Lerp(speedMixMax.x, speedMixMax.y, Difficulty.GetDifficultyPercent()); Increase Speed Gradually
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime ,Space.World);

    }
}