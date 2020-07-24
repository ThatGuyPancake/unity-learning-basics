
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraSelector : MonoBehaviour
    {
        public Camera main;
        public Camera cinematic;
        public Camera topDown;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                cinematic.enabled = topDown.enabled = false;
                main.enabled = true;
            } else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                main.enabled = topDown.enabled = false;
                cinematic.enabled = true;
            } else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                main.enabled = cinematic.enabled = false;
                topDown.enabled = true;
            }
        }
    }
}