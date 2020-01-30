using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        [SerializeField]
    private bool _stopSpawning = false;

    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
