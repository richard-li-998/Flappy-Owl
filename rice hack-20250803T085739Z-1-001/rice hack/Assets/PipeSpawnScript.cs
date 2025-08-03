using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.5f;
    private float timer = 0;
    public float heightOffset = 3f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else{
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(transform.position.y - heightOffset, transform.position.y + heightOffset)), transform.rotation);
    }
}
