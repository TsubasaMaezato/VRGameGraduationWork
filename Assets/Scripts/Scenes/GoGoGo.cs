using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGoGo : MonoBehaviour
{
    private Vector3 player_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Clamp()
    {
        player_pos = transform.position;

        player_pos.z = Mathf.Clamp(player_pos.z, -1f, 1f);
        transform.position = new Vector3(player_pos.x, player_pos.y, player_pos.z);


    }
}
