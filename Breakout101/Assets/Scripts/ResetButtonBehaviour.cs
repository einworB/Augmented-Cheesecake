using UnityEngine;
using System.Collections;

public class ResetButtonBehaviour : MonoBehaviour {

    private GameObject upperWall;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseEnter()
    {
        gameObject.guiText.color = new Color32(255, 13, 13, 155); //red
    }

    void OnMouseDown()
    {
        gameObject.guiText.color = new Color32(255, 13, 13, 155); //red
        resetBall();
    }


    void OnMouseExit()
    {
        gameObject.guiText.color = new Color32(255, 255, 255, 255);  //white
    }
    private void resetBall()
    {
        upperWall = GameObject.FindGameObjectWithTag("UpperWall");
        Vector3 pos = new Vector3(upperWall.transform.position.x, upperWall.transform.position.y - 2.2f, upperWall.transform.position.z);
        Debug.Log(upperWall.transform.position.y);
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        ball.transform.position = pos;
        DestroyBricks.minusPoints();
 
    }
}
