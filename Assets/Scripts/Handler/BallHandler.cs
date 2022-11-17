using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallHandler : MonoBehaviour
{

    public static float rotationSpeed = 75f;
    
    private static Color _oneColor;
    public GameObject ball;

    private float speed = 100;

    private void Start()
    {
        MakeANewCircle();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            HitBall();
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void HitBall()
    {
        GameObject gameObject = Instantiate<GameObject>(ball, new Vector3(0, 0, -8), Quaternion.identity);
        gameObject.GetComponent<MeshRenderer>().material.color = _oneColor;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }

    void MakeANewCircle()
    {
        GameObject gameObject2 = Instantiate(Resources.Load("round" + Random.Range(1,4))) as GameObject;
        gameObject2.transform.position = new Vector3(0, 0, 23);
        gameObject2.name = "Circle";
    }
}
