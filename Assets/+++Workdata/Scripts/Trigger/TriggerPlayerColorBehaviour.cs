using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KunstSchuleWandsbek
{
    public class TriggerPlayerColorBehaviour : MonoBehaviour
    {
        public Color playerColor;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<SpriteRenderer>().color = playerColor;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}
