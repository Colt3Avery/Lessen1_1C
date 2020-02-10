using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
   public float Vspeed = 20;
    public float Hspeed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * Vspeed * VerticalInput);
       // transform.Translate(Vector3.right * Time.deltaTime * Hspeed * HorizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * Hspeed * HorizontalInput);
    }
}
