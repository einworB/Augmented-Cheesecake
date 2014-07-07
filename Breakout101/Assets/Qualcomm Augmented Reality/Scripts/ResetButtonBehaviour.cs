using UnityEngine;
using System.Collections;

public class ResetButtonBehaviour : MonoBehaviour {

	// Use this for initialization
    private Vector3 defaultPos = new Vector3(0,0.2f,0);
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseEnter()
    {
        gameObject.guiText.color = new Color32(255, 13, 13, 155); //red
        resetBall();
    }

    void OnMouseUp()
    {
        
    }

    void OnMouseExit()
    {
        gameObject.guiText.color = new Color32(255, 255, 255, 255);  //white
    }

    private void resetBall()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        ball.transform.position = defaultPos;
        //DestroyBricks.minusPoints();
    }
}
