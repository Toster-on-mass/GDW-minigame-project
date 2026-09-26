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
    private Vector2 currentFacingDirection = new Vector2(1,0);
    public InputAction netAction;

    // 0 - Default Movement
    // 1 - Using Net
    // 2 - Got hit by !FISH!
    public int currentState = 0;

    public float netTimer = 1.0f;
    public float netActiveTimer = 0.3f;
    private float netTimerCurrent = 0;

    public NetCapture playerNetCapture;
    public KillFish playerFishKiller;
    public MeshRenderer netPrototypeMeshRenderer;
    public Material[] netPrototypeMats;


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

        // Need to make it not the input or it can be 0
        if (moveInput.x != 0)
        {
            currentFacingDirection = moveInput;
        }

        // This is one wall you cannot crawl, Spiderman
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

        if (netTimerCurrent >= netActiveTimer && currentState != 2)
        {
            playerFishKiller.active = false;
            netPrototypeMeshRenderer.material = netPrototypeMats[1];
        }

        if (netTimerCurrent >= netTimer && currentState != 2)
        {
            currentState = 0;
            playerNetCapture.DeactivateNet();
            netPrototypeMeshRenderer.material = netPrototypeMats[2];
        }
    }

    void NetInputCheck()
    {
        if (netAction.WasPressedThisFrame())
        {
            netTimerCurrent = 0.0f;
            currentState = 1;
            playerNetCapture.ActivateNet(currentFacingDirection);
            playerFishKiller.active = true;
            netPrototypeMeshRenderer.material = netPrototypeMats[0];
        }
    }
}
