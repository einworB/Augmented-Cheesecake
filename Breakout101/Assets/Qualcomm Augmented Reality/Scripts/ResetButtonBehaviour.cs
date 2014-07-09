using UnityEngine;
using System.Collections;

public class ResetButtonBehaviour : MonoBehaviour {

    private GameObject upperWall;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            gameObject.guiText.color = new Color32(255, 13, 13, 155); //red
            resetBall();
        }
	}

    private void resetBall()
    {
        upperWall = GameObject.FindGameObjectWithTag("UpperWall");
        Vector3 pos = new Vector3(upperWall.transform.position.x, upperWall.transform.position.y - 0.2f, upperWall.transform.position.z);
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        ball.transform.position = pos;
        DestroyBricks.minusPoints();
        gameObject.guiText.color = new Color32(255, 255, 255, 255);  //white
    }
}
