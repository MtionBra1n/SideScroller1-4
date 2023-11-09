using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(gameObject.GetComponent<ScriptA>().objectName);
    }
}
