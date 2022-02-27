using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomTeplate teplate;

    private void Start()
    {
        teplate = GameObject.FindGameObjectWithTag("Room").GetComponent<RoomTeplate>();
        teplate.rooms.Add(this.gameObject);
    }
}
