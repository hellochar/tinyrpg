using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistAcrossScenes : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
