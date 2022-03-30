using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject door;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 1f;
        door.transform.position = new Vector3(value, 0, 0);
    }

    public void RotateLeft()
    {
        door.transform.Rotate(20f, 0f, 0f);
    }

    public void Grow()
    {
        door.transform.localScale = door.transform.localScale + sizeChange;
    }

    public void ResetDoor()
    {
        door.transform.position = new Vector3(0, 0, 0);
        door.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        door.transform.localScale = new Vector3(1, 1, 1);
    }
}
