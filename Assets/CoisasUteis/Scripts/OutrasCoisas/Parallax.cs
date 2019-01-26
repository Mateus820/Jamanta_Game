using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour {

    public RawImage img;
    public float speed;
    private const float TIMER_OFFSET = 0.01f;

	void Update () {
        Rect rect = img.uvRect;
        rect.x += speed * Time.deltaTime * TIMER_OFFSET;
        img.uvRect = rect;
	}
}
