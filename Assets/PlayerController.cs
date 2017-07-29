using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputController inputController;
    public float moveSpeed = 3f;
    public GameObject player;
    private Rigidbody2D playerRB;

    // Use this for initialization
    void Start()
    {
        playerRB = player.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = player.transform.position;
        float updateMoveSpeed = moveSpeed * Time.deltaTime;
        if (inputController.GetKey(InputController.Key.WALK_LEFT))
        {
            player.transform.position =
                new Vector3(cameraPosition.x - updateMoveSpeed, cameraPosition.y, cameraPosition.z);
        }
        if (inputController.GetKey(InputController.Key.WALK_RIGHT))
        {
            player.transform.position =
                new Vector3(cameraPosition.x + updateMoveSpeed, cameraPosition.y, cameraPosition.z);
        }
        if (inputController.GetKeyDown(InputController.Key.JUMP))
        {
//            playerRB.
        }
    }
}