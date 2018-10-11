using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject target;

    [Range(0f, 50f)]
    public float MaxTopY;

    [Range(0f, -50f)]
    public float MaxBottomY;

    private bool isDead = false;

    void Update () {
        if (!isDead)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

            if (target.transform.position.y > MaxTopY)
            {
                transform.position = new Vector3(transform.position.x, MaxTopY, transform.position.z);
            }
            if (target.transform.position.y < MaxBottomY)
            {
                transform.position = new Vector3(transform.position.x, MaxBottomY, transform.position.z);
            }
        }
    }

    public void setDeath()
    {
        isDead = true;
        Debug.Log("splat");
    }
}


