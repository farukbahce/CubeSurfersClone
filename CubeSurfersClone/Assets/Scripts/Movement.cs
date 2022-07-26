using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float turningSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime ;
        this.transform.Translate(yatayEksen,0,speed * Time.deltaTime);

    }
}
