using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float playerYPos;

    // Start is called before the first frame update
    void Start()
    {
        playerYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            //player position switch

            playerYPos = -playerYPos;

            transform.position = new Vector3(transform.position.x, playerYPos, transform.position.z);
        }
    }
}
