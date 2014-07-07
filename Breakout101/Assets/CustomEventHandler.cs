using UnityEngine;
using System.Collections;

public class CustomEventHandler : MonoBehaviour
{

    private TrackableBehaviour mTrackableBehaviour, ITrackableEventHandler;
    private bool isRenderer = false;
    private GameObject ball;

	// Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update () {
        if (isRenderer)
        {
            //ball.transform.position -= ball.transform.up * 5.0f * Time.deltaTime;
          // ball.AddComponent<Rigidbody>();
        }
	}

    private void OnTrackingFound()
    {
       /* Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

        // Enable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = true;
        }

        // Enable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = true;
        }

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

        isRenderer = true; */
    }

    private void OnTrackingLost()
    {
        /*Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

        // Disable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = false;
        }

        // Disable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = false;
        }

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        isRenderer = false;*/
    }
 }
