using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject theSpawnee;
    GameObject spawnClone;
    public int speed;
    public float size;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            size = Random.Range(1.0f, 5.0f);
            spawnClone = Instantiate(theSpawnee, spawnPos.position, spawnPos.rotation);
            spawnClone.transform.localScale = new Vector3(size, size, size);
            spawnClone.GetComponent<Rigidbody>().velocity = spawnClone.transform.forward * speed;
            
        }
    }
}
