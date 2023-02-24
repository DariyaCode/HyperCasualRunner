using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //one of to move the obstacles
        //transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < -10f){
            Destroy(gameObject);
        }
    }
}
