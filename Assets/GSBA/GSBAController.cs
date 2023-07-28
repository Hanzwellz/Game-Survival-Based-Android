using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSBAController : MonoBehaviour
{
    public GameObject Character;
    public FixedJoystick fixedJoystick;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (fixedJoystick.Vertical > 0) { //control up
            Character.transform.Translate(Vector2.up * Time.deltaTime * speed);
        } else if (fixedJoystick.Vertical < 0){ //control down
            Character.transform.Translate(Vector2.down * Time.deltaTime * speed);
        }

        if (fixedJoystick.Horizontal > 0){  //control right
            Character.transform.Translate(Vector2.right * Time.deltaTime * speed);
        } else if (fixedJoystick.Horizontal < 0){ //control left
            Character.transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

    }
}
