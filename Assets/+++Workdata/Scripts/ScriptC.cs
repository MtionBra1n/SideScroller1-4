using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ScriptC : MonoBehaviour
{
    public GameObject objectAB;
    private void Start()
    {
        Debug.Log(objectAB.GetComponent<ScriptA>().objectName);
        Debug.Log(gameObject.name);
        Debug.Log(objectAB.name);
    }
}
