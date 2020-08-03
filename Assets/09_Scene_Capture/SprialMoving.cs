using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SprialMoving : MonoBehaviour
{
    public GameObject object1; //1->2 방향으로 움직인다.
    public GameObject object2;
    public bool moveUpDown = true;
    public bool movingDirection = true; //if true, up.
    public float radius = 0.15f;

    public float rotateSpeed = 4;
    private Vector3 position;
    private Vector3 rotateVector;


    void Start()
    {
        transform.position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + radius, transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        position = Vector3.Lerp(object1.transform.position, object2.transform.position, 0.1f);
        rotateVector =  object1.transform.position - object2.transform.position;
        
        transform.RotateAround(position, rotateVector, rotateSpeed);       
        if (moveUpDown) {
            if (isAfter(transform, object2.transform)) {
                movingDirection = true;
            } else if (isAfter(object1.transform, transform)) {
                movingDirection = false;
            }

            //TODO: 방향 계산 변경 필요.
            transform.position = Vector3.MoveTowards(transform.position, transform.position + rotateVector * convertBoolToPositiveOrNegative(movingDirection), 0.002f);
        }
    }

    //TODO: before 여부 계산 변경 필요
    private bool isBefore(Transform target, Transform current) {
        Vector3 forward = current.TransformDirection(Vector3.right);
        Vector3 toOther = target.position - current.position;

        return Vector3.Dot(forward, toOther) < 0;
    }

    
    private bool isAfter(Transform target, Transform current) {
        return isBefore(current, target);
    }

    private int convertBoolToPositiveOrNegative(bool boolean) {
        return (-1 + 2 * Convert.ToInt16(boolean));
    }
}
