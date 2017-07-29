using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject background;
    public GameObject mainCamera;
    public GameObject inputController;

    // Use this for initialization
    void Start()
    {
        centerBackground();
    }

    // Update is called once per frame
    void Update()
    {
        centerBackground();
    }

    private void centerBackground()
    {
        background.transform.position =
            new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 0);
    }
}