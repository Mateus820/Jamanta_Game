using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	[SerializeField] private float xSmooth , ySmooth;
	[SerializeField] private bool limit;
	[SerializeField] private GameObject player;
    [SerializeField] private Vector2 speed;
    [SerializeField] private Vector3 minCam , maxCam;

	void FixedUpdate () {

        float x = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref speed.x, xSmooth);
		float y = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref speed.y, ySmooth);

        transform.position = new Vector3 (x, y, transform.position.z);

        if (limit)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCam.x, maxCam.x),
            Mathf.Clamp(transform.position.y, minCam.y, maxCam.y),
            Mathf.Clamp(transform.position.z, minCam.z, maxCam.z));
        }
    }
}
