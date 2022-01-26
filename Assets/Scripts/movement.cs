using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody player;
    public float m_speed,  s_speed;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.velocity = transform.forward * m_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.velocity = -transform.forward * m_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.velocity = -transform.up * s_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.velocity = transform.up * s_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = transform.right * s_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = -transform.right * s_speed * Time.deltaTime;
        }
       
        
    }
}
