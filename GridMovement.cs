using System.Collections
using System.Collections.Generic;
using UnityEngine;


public class GridMovement : Monobehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.5f;
    void Update()
    {
        If (Input.GetKey(KeyCode.W) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.up));
            
        If (Input.GetKey(KeyCode.A) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.left));

        If (Input.GetKey(KeyCode.S) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.down));

        If (Input.GetKey(KeyCode.D) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 drection)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while(elaspsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elaspsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;

        }

        transform.position = targetPos;

        isMoving = false;
    }
}
