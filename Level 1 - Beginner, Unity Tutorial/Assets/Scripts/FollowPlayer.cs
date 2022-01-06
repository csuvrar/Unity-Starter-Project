using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    // camera offset from player
    public Vector3 offset = new Vector3(0, 5, -8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame to allow camera follow vehicle more smoothly (camera move after vehicle move)
    void LateUpdate()
    {
        // follow the player
        transform.position = player.transform.position + offset;
    }
}
