using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBoxFollow : MonoBehaviour
{

    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position;
    }
}
