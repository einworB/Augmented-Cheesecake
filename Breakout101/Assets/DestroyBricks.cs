using UnityEngine;
using System.Collections;

public class DestroyBricks : MonoBehaviour {

    public GameObject points;
    private int currentPoints = 0;

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
}
