﻿using UnityEngine;
using System.Collections;

public class DestroyBricks : MonoBehaviour {

    public static GameObject points;
    private static int currentPoints = 0;


    void Start()
    {
        points = GameObject.FindGameObjectWithTag("pointsText");
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Brick" || col.gameObject.name == "breze")
        {
            Destroy(col.gameObject);
            currentPoints += 100;
            points.GetComponent<TextMesh>().text = "Points " + currentPoints;
        }
    }

    public static void minusPoints()
    {
        if (points!=null) {
            currentPoints -= 25;
            points.GetComponent<TextMesh>().text = "Points " + currentPoints;
        }
        
    }
}
