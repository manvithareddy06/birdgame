using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float Timer = 0;

    public float HeightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate)
        {
            Timer = Timer + Time.deltaTime;
        }

        else
        {
            spawnpipe();
            Timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - HeightOffset;
        float Higestpoint = transform.position.y + HeightOffset;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, Higestpoint), 0), transform.rotation);
    }
}
