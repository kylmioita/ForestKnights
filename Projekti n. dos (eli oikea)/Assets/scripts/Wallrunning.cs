//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Wallrunning : MonoBehaviour
//{
//    [Header("Wallrunning")]
//    public LayerMask whatIsWall;
//    public LayerMask whatIsGround;
//    public float wallRunForce;
//    public float maxWallRunTime;
//    private float wallRunTimer;

//    [Header("Input")]
//    private float horizontalInput;
//    private float verticalInput;

//    [Header("Detection")]
//    public float wallCheckDistance;
//    public float minJumpHeight;
//    private RaycastHit leftWallhit;
//    private RaycastHit rightWallhit;
//    private bool wallleft;
//    private bool wallright;

//    [Header("References")]
//    public Transform orientation;
//    private PlayerMovement pm;
//    private Rigidbody rb; 

//    private void Start()
//    {
//        rb = GetComponent<RigidBody>();
//        pm = GetComponent<PlayerMovement>();
//    }

//    private void update()
//    {
//        CheckForWall();
//    }
//    private void CheckForWall()
//    {
//        wallright = Physics.Raycast(transform.position, orientation.right, out rightWallhit, wallCheckDistance, whatIsWall);
//        wallleft = Physics.Raycast(transform.position, orientation.right, out leftWallhit, wallCheckDistance, whatIsWall);
//    }
//    private bool AboveGround()
//    {
//        return !Physics.Raycast(transform.position, Vector3.down, minJumpHeight, whatIsGround);
//    }
//    private void StateMachine()
//        horizontalInput = Input.GetAxisRaw("Horizontal");
//        verticalInput = Input.GetAxisRaw("Vertical");
//        if((wallleft ))



//}
