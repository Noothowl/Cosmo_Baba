using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour
{
    public GameObject pipes;
    protected float spawn_rate = 2f;
    protected float timer = 0;

    protected float hight = 2.75f;

    // Start is called before the first frame update
    void Start()
    {
        first_spawn();
    }

    // Update is called once per frame
    void Update()
    {
        spawner();
    }

    void spawner()
    {
        float lowest = transform.position.y - hight;
        float highest = transform.position.y + hight;

        if (timer < spawn_rate)
        {
            timer += Time.deltaTime;
        }else {
            // Instantiate (prefab, with vector 3(same X, rangom Y between lowest and highest, 0 Z), same rotation as prefab);
            Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowest, highest),0), transform.rotation);
            timer = 0;
        }
        
    }

    void first_spawn()
    {
        Instantiate(pipes,transform.position, transform.rotation);
    }
}
