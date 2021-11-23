using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    #region ATTRIBUTES
    [SerializeField] WaveManagerScriptableObject waveManagerScriptableObject;
    #endregion

    #region MONOBEHAVIOUR METHODS
    void Start()
    {

    }
    void Update()
    {
        WaveController();
    }
    #endregion

    #region METHODS
    void WaveController()
    {
        if(waveManagerScriptableObject.beginWave)
        {
            Debug.Log("wave started");
            waveManagerScriptableObject.beginWave = false;
        }
    }

    #endregion
}
