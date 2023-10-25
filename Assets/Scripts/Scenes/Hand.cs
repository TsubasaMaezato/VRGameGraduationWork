using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
   // [SerializeField] private float _minZ = 0;
   // [SerializeField] private float _maxZ = 1;
    private Vector3 player_pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.MovePosition(target.transform.position);
    }

    /*void Clamp()
    {
        player_pos = transform.position;

        player_pos.z = Mathf.Clamp(player_pos.z, -1f, 1f);
        transform.position = new Vector3(player_pos.x, player_pos.y, player_pos.z);

    
    */
   /* private void Update()
    {
        var pos = transform.position;

       
        pos.z = Mathf.Clamp(pos.z, _minZ,_maxZ);

        transform.position = pos;
    }
   */
}

