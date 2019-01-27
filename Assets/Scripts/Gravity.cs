using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity;

    public void Attract(Transform tr, Rigidbody2D rb){
        Vector2 targetDir = (tr.position - transform.position).normalized;
        Vector2 bodyUp = tr.transform.up;

        tr.rotation = Quaternion.FromToRotation(bodyUp, targetDir) * tr.rotation;
        rb.AddForce(targetDir * gravity * 10);
    }
}
