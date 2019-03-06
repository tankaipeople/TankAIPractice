using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RR
{
public class AI : MonoBehaviour
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
        Instantiate(bullet, Po.transform.position, Po.rotation );
        InvokeRepeating("aa", 1f, 0.5f);
        
        bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }
    public float x;
    void aa()
    {
        Instantiate(bullet, Po.transform.position, Po.rotation);
    }
    void Update()
    {
        x += Time.deltaTime * 100;
        headTransform.rotation = Quaternion.Euler(0, x, 0);
    }
}


};