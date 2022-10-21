using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{


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
