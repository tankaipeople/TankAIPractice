using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DD
{
    public class TankAI : MonoBehaviour
    {
        private Rigidbody rb;
        private Transform headTransform;
        private Transform Po;
        public GameObject bullet;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            headTransform = transform.GetChild(1).transform;
            Po = headTransform.GetChild(0).GetChild(0);
            headTransform.rotation = Quaternion.EulerRotation(0, 45, 0);
            Instantiate(bullet, Po);
        }

        private void Update()
        {
            if (Physics.Raycast(this.transform.position, transform.forward, 3f))
            {
                transform.rotation = transform.rotation * Quaternion.EulerRotation(0, 90, 0);
            }
            else
            {
                transform.Translate(new Vector3(0, 0, 1f * Time.deltaTime));
            }
        }
    }
}