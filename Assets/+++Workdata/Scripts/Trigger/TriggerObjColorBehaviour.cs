using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KunstSchuleWandsbek
{
    public class TriggerObjColorBehaviour : MonoBehaviour
    {
        public GameObject cube;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                cube.GetComponent<SpriteRenderer>().color = Color.cyan;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                cube.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}
