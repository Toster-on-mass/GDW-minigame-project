using System.Threading;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public float movementCutoff = 8.5f;

    public InputAction moveAction;
    private Vector2 moveInput;
    public InputAction netAction;

    // 0 - Default Movement
    // 1 - Using Net
    // 2 - Got hit by !FISH!
    public int currentState = 0;

    public float netTimer = 1.0f;
    private float netTimerCurrent = 0;

    public NetCapture playerNetCapture;

    void Start()
    {
        moveAction.Enable();
        netAction.Enable();
    }

    void Update()
    {
        if (currentState == 0)
        {
            MoveLogic();
            NetInputCheck();
        }
        else if (currentState == 1)
        {
            NetUsingLogic();
        }
    }

    void MoveLogic()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(moveInput * moveSpeed * Time.deltaTime);

        if (transform.position.x > movementCutoff)
        {
            transform.position = new Vector3(movementCutoff, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -movementCutoff)
        {
            transform.position = new Vector3(-movementCutoff, transform.position.y, transform.position.z);
        }
    }

    void NetUsingLogic()
    {
        netTimerCurrent += Time.deltaTime;
        if (netTimerCurrent >= netTimer && currentState != 2)
        {
            currentState = 0;
        }
    }

    void NetInputCheck()
    {
        if (netAction.WasPressedThisFrame())
        {
            netTimerCurrent = 0.0f;
            currentState = 1;
        }
    }
}
