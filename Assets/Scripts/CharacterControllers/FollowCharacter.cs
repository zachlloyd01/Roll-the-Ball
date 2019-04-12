using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public GameObject character;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = character.transform.position.x;
        float y = character.transform.position.y;
        float z = character.transform.position.z;
        y += 60f;
        camera.transform.position = new Vector3(x, y, z);
    }
}
