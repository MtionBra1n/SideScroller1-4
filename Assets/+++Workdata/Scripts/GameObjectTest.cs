using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    private void Update()
    {
        Debug.Log(gameObject.GetComponent<CharacterMovement>().isMoving);
    }
}
