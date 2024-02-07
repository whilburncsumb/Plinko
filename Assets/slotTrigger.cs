using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotTrigger : MonoBehaviour
{
    public int slotNumber;
    public int points;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} entered slot {slotNumber} and got {points} points");
        Destroy(other.gameObject);
    }
}
