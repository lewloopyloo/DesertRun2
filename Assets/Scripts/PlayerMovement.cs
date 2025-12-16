using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    [SerializeField] bool isRunning;
    

    void Update()
    {
        Debug.Log("PlayerMovement Update running");
        if (!isRunning)
        {
            isRunning = true;
            StartCoroutine(AddDistance());
        }

        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * horizontalSpeed * dt, Space.World);
                Vector3 p = transform.position;
                if (p.x < leftLimit) p.x = leftLimit;
                transform.position = p;
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * horizontalSpeed * dt, Space.World);
                Vector3 p = transform.position;
                if (p.x > rightLimit) p.x = rightLimit;
                transform.position = p;
            }
        }

    }
    IEnumerator AddDistance()
    {
        yield return new WaitForSeconds(0.35f);
        
        MasterInfo.distanceRun += 1;

        isRunning = false;
        
    
    }

}
