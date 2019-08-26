using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private JoystickInput moveJoystick;
    public static Vector2 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") + moveJoystick.moveDir.x;
        float y = Input.GetAxis("Vertical")+moveJoystick.moveDir.y;
        moveDir = new Vector2(x, y);
    }
}
