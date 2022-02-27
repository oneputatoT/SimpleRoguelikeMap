using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTeplate : MonoBehaviour
{
    public GameObject[] bottom;
    public GameObject[] top;
    public GameObject[] left;
    public GameObject[] right;

    public GameObject closeRoom;
    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnBoss;
    public GameObject boss;

    private void Update()
    {
        if (waitTime <= 0 && spawnBoss == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                    Instantiate(boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
            }
            spawnBoss = true;
        }
        else
            waitTime -= Time.deltaTime;
    }
}
