using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    //if 1 need bottom
    //if 2 need top
    //if 3 need left
    //if 4 need right
    public int direction;


    private RoomTeplate teplates;
    private int rand;
    private bool spawn=false;

    public float waitTime = 15f;

    private void Start()
    {
        Destroy(gameObject, waitTime);
        teplates = GameObject.FindGameObjectWithTag("Room").GetComponent<RoomTeplate>();
        Invoke("Spawn", 0.2f);
    }


    private void Spawn()
    {
        if (spawn == false)
        {
            if (direction == 1)
            {
                rand = Random.Range(0, teplates.bottom.Length);
                Instantiate(teplates.bottom[rand], transform.position, Quaternion.identity);
            }
            else if (direction == 2)
            {
                rand = Random.Range(0, teplates.top.Length);
                Instantiate(teplates.top[rand], transform.position, Quaternion.identity);
            }
            else if (direction == 3)
            {
                rand = Random.Range(0, teplates.left.Length);
                Instantiate(teplates.left[rand], transform.position, Quaternion.identity);
            }
            else if (direction == 4)
            {
                rand = Random.Range(0, teplates.right.Length);
                Instantiate(teplates.right[rand], transform.position, Quaternion.identity);
            }
            spawn = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Close"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("SpawnPoint"))
        {
            if (collision.GetComponent<SpawnPoint>().spawn == false && spawn == false)
            {
                Instantiate(teplates.closeRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
        spawn = true;
    }
}
