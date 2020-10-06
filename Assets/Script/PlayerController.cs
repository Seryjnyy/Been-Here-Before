using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 2.0f;
    [SerializeField] bool lockCursor = true;
    [SerializeField] float walkSpeed = 6.0f;
    [SerializeField] float gravity = -13.0f;
    [SerializeField][Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;

    // UI on paper, showing instrucitons
    public LevelMetaData level;
    public test ts;

    float cameraPitch = 0.0f;
    float velocityY = 0.0f;
    CharacterController controller = null;

    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;


    void Start() {
        controller=GetComponent<CharacterController>();
        if(lockCursor) {
            Cursor.lockState=CursorLockMode.Locked;
            Cursor.visible=false;
        }
        // UI on paper, showing instrucitons
        ts=GameObject.FindGameObjectWithTag("InstructionText").GetComponent<test>();
        ts.LoadText(level.level1,1);
        level.ToysCollected=0;
    }
public void MoveToLocation(Vector3 newPosition){
    transform.position = newPosition;
}


    void Update()
    {
        // UI on paper, showing instrucitons
        if(Input.GetKeyDown(KeyCode.R)) {
            ts.LoadText(level.level2,-1);
        }
        if(Input.GetKeyDown(KeyCode.T)) {

            ts.LoadText(level.level1,1);
        }
        UpdateMouseLook();
        UpdateMovement();
    }
    void UpdateMouseLook() {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
        
        transform.Rotate(Vector3.up*mouseDelta.x*mouseSensitivity); // we are rotating the object on its y axis
        cameraPitch -= mouseDelta.y*mouseSensitivity;
        cameraPitch=Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        playerCamera.localEulerAngles=Vector3.right*cameraPitch;
    }

    void UpdateMovement() {
        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir=Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);

        if(controller.isGrounded) 
            velocityY=0.0f;

        velocityY+=gravity*Time.deltaTime;


        Vector3 velocity = (transform.forward*currentDir.y+transform.right*currentDir.x)*walkSpeed + Vector3.up*gravity;
        controller.Move(velocity*Time.deltaTime);
    }
}
