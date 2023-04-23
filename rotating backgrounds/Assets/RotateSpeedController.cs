//using UnityEngine;

//public class RotateSpeedController : MonoBehaviour
//{
//    rotation rotationScript; // Reference to the "Rotation" script
//    public float speedChangeAmount = 5f; // Amount to increase or decrease "RotateSpeed" by

//    void Start()
//    {
//        rotationScript = GetComponent<rotation>();
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.RightArrow))
//        {
//            rotationScript.RotateSpeed += speedChangeAmount;
            
//        }
//        else if (Input.GetKeyDown(KeyCode.LeftArrow))
//        {
//            rotationScript.RotateSpeed -= speedChangeAmount;
//            transform.Rotate(0f, 0f + speedChangeAmount, 0f);
//        }
//    }
//}
