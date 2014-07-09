using UnityEngine;
using System.Collections;

public class ResetButtonBehaviour : MonoBehaviour {

    private GameObject upperWall;

	// Use this for initialization
	void Start () {
        Debug.Log("I Started");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseUp ()
    {
    }

    void OnMouseDown()
    {
        if (gameObject.guiText.text == "New Ball")
        {
            gameObject.guiText.color = new Color32(255, 13, 13, 155); //red
            resetBall();
        }
        else
        {
            gameObject.guiText.text = "New Ball";
            gameObject.guiText.color = new Color32(255, 255, 255, 255);  //white
            GameObject ball = GameObject.FindGameObjectWithTag("ball");
            //ball.AddComponent<Rigidbody> ();
            ball.rigidbody.isKinematic = false;
            ball.rigidbody.useGravity = true;
        }
        
    }


    void OnMouseExit()
    {

        
    }

    private void resetBall()
    {
        upperWall = GameObject.FindGameObjectWithTag("UpperWall");
        Vector3 pos = new Vector3(upperWall.transform.position.x, upperWall.transform.position.y - 2.205f, upperWall.transform.position.z);
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        //Destroy(ball.rigidbody);
        ball.rigidbody.isKinematic = true;
        ball.transform.position = pos;
        DestroyBricks.minusPoints();
        gameObject.guiText.text = "Start";
 
    }
}
