using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	     //Variables
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F; 
    public float gravity = 20.0F;

    public Transform cam;
	public Transform capsule;
    private Vector3 moveDirection = Vector3.zero;
	public Vector3 newPos;

	void Start() {
		newPos = new Vector3(0, cam.localEulerAngles.y, 0);
		cam.localEulerAngles = new Vector3(cam.localEulerAngles.x, 0 ,cam.localEulerAngles.z);
		capsule.localEulerAngles = newPos;
	}

    void Update() {

		newPos = new Vector3(0, cam.localEulerAngles.y, 0);
		cam.localEulerAngles = new Vector3(cam.localEulerAngles.x, 0 ,cam.localEulerAngles.z);
		capsule.localEulerAngles = newPos;
			
		capsule.Rotate(new Vector3(0, 0, 0));

        CharacterController controller = GetComponent<CharacterController>();
        // is the controller on the ground?
        if (controller.isGrounded) {
			if (Input.GetKey(KeyCode.LeftShift)) { //sprinting
				speed = 12f;
			} else {
				speed = 6f;
			}

            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            //Jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
             
        }
        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
     }
}
 