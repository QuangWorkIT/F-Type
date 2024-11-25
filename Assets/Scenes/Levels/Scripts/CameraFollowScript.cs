using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform followTransform;
    public float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);

        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, smoothSpeed);
    }
}
