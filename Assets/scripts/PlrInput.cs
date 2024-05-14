using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlrInput : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;
        private Vector3 movement;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }


        void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVar.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVar.VERTICAL_AXIS);

            movement= new Vector3(-horizontal, 0, -vertical).normalized;
        }

        private void FixedUpdate()
        {
            MoveCharacter();
        }

        private void MoveCharacter()
        {
            playerRigidbody.AddForce(movement * speed);
        }

#if UNITY_EDITOR
        [ContextMenu("ResetValues")]
        public void ResetValuse()
        {
            speed = 2;
        }
#endif
    }
}
