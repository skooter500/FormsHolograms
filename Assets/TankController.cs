using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{

    void Start()
    {
        Vector3 a = new Vector3(5,6, 0);
        Vector3 b = new Vector3(11, 8, 0);

        Vector3 c = b - a;

        Debug.Log(c);
        Debug.Log(c.magnitude);

        Debug.Log(Vector3.Normalize(c));

        float theta = 90 + Mathf.Atan(c.y / c.x) * Mathf.Rad2Deg;

        Debug.Log(theta);


    }


    public void Move(InputAction.CallbackContext context)
    {
        float f = context.ReadValue<float>();
        Debug.Log(f);
    }

    /*
    private TankControls tc;
    // Start is called before the first frame update
    void Start()
    {
        // Add listenets to events
        tc.Land.Shoot.started += Shoot;
    }

    void Awake()
    {
        tc = new TankControls();
    }

    void Shoot(InputAction.CallbackContext context)
    {

    }

    void OnEnable()
    {
        tc.Enable();
    }

    void OnDisable()
    {
        tc.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float f = tc.Land.Move.ReadValue<float>();
        Debug.Log(f);
    }
    */
}
