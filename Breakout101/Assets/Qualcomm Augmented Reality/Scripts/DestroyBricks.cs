using UnityEngine;
using System.Collections;

public class DestroyBricks : MonoBehaviour {

    public static GameObject pointsBricks;
    public static GameObject pointsBrezen;
    private static int currentPoints = 0;


    void Start()
    {
        pointsBricks = GameObject.FindGameObjectWithTag("pointsText");
        pointsBrezen = GameObject.FindGameObjectWithTag("pointsText2");
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Brick")
        {
            Destroy(col.gameObject);
            currentPoints += 100;
            pointsBricks.GetComponent<TextMesh>().text = "Score " + currentPoints;
        }
        else if (col.gameObject.name == "breze")
        {
            Destroy(col.gameObject);
            currentPoints += 100;
            pointsBrezen.GetComponent<TextMesh>().text = "Score " + currentPoints;
          
        }
    }

    public static void minusPoints()
    {
        if (pointsBricks!=null) {
            currentPoints -= 25;
            pointsBricks.GetComponent<TextMesh>().text = "Score " + currentPoints;

        }
        else if (pointsBrezen != null)
        {
            currentPoints -= 25;
            pointsBrezen.GetComponent<TextMesh>().text = "Score " + currentPoints;
        }
        
    }
}
