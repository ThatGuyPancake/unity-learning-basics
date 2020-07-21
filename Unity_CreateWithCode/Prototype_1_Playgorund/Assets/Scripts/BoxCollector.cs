using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class BoxCollector : MonoBehaviour
    {
        public GameObject box;
        public TextMeshPro scoreBox;
        private int score;

        private void OnCollisionEnter(Collision other)
        {
            if (other.transform.parent == box.transform)
            {
                score++;
                scoreBox.SetText("score = " + score);
                Destroy(other.gameObject);
            }
        }
    }
}