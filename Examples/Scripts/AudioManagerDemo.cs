using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sundog.Common.Audio;

public class AudioManagerDemo : MonoBehaviour
{
    [SerializeField]
    private KeyCode testKey = KeyCode.F;
    [SerializeField]
    private AudioEvent testEvent = null;

    private void Update()
    {
        if (Input.GetKeyDown(testKey))
        {
            AudioManager.PlayEvent(testEvent, gameObject);
        }
    }
}
