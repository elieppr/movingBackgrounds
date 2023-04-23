using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    public float RotateSpeed = 1.5f;
    public float speedChangeAmount = 0.5f; // Amount to increase or decrease "RotateSpeed" by

    // Update is called once per frame
    void Update()
    {
        //RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateSpeed += speedChangeAmount;

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateSpeed -= speedChangeAmount;
            //transform.Rotate(0f, 0f + speedChangeAmount, 0f);
        }
    }
}
