using UnityEngine;
using System.Collections;

public class DestroyBricks : MonoBehaviour {

    public static GameObject points;
    private static int currentPoints = 0;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Brick")
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
