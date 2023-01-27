using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float horAxes = Input.GetAxis("Horizontal");
        float verAxes = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horAxes, 0, verAxes) * speed * Time.deltaTime);
    }
}
