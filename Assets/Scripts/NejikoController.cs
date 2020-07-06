using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NejikoController : MonoBehaviour {
	CharacterController controller;
	Animator animator;
	AudioSource walksound;
	AudioSource jumpsound;
	public Button run;
	public Button walk;
	Vector3 moveDirection = Vector3.zero;
	public float gravity;
	float speedZ;
	public float speedJump;
	public SCharacter scharacter;
	public Stick stick;
	public Jumper jumper;
	public Button jumpbutton;
	int backrotation;
	int frontrotation;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		var audios = GetComponents<AudioSource>();
		walksound = audios [0];
		jumpsound = audios [1];
		speedZ = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (scharacter.GetSelect ()==this.tag) {
			if (controller.isGrounded) {
				if (Input.GetButtonDown ("Jump")||jumper.GetJumpState()) { //for pc/moblie
					moveDirection.y = speedJump;
					animator.Play ("JUMP00");
					jumper.ChangeJumpState ();
					if (!jumpsound.isPlaying)
						jumpsound.Play ();
				}
			}
			if (moveDirection.z < -0.1) {
				transform.Rotate (0, Input.GetAxis ("Horizontal"), 0); //for pc
				transform.Rotate (0, stick.GetJoystickPosition ().x, 0);
				moveDirection.z = stick.GetJoystickPosition().y * 5;
			} else {
				transform.Rotate (0, Input.GetAxis ("Horizontal") * 2, 0); //for pc
				transform.Rotate (0, stick.GetJoystickPosition ().x * 2, 0);
				moveDirection.z = stick.GetJoystickPosition().y * speedZ;
			}
			//animator.SetFloat ("h", Input.GetAxis ("Horizontal")); //for pc
			animator.SetFloat ("h", stick.GetJoystickPosition().x);
			//animator.SetFloat ("v", Input.GetAxis ("Vertical")); //for pc
			animator.SetFloat ("v", stick.GetJoystickPosition().y);
			if ((Input.GetAxis("Vertical")>0.1 || stick.GetJoystickPosition ().y > 0.1 )&& !walksound.isPlaying)
				walksound.Play ();
			moveDirection.y -= gravity * Time.deltaTime;

			//if((Input.GetAxis("Vertical") < -0.1 || stick.GetJoystickPosition ().y < -0.1 ))
			Vector3 globalDirection = transform.TransformDirection (moveDirection);
			controller.Move (globalDirection * Time.deltaTime);
			if (controller.isGrounded)
				moveDirection.y = 0;
			//animator.SetBool ("run", moveDirection.z > 0.0f);
			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("JUMP00"))
				jumpbutton.interactable = false;
			else
				jumpbutton.interactable = true;
		}
		if(Input.GetKey(KeyCode.Z)) scharacter.Change("C1");
		if(Input.GetKey(KeyCode.X)) scharacter.Change("C2");
		if(Input.GetKey(KeyCode.C)) scharacter.Change("C3");
	}
	public void runbutton(){
		speedZ = 8;
		run.interactable = false;
		walk.interactable = true;
	}
	public void walkbutton(){
		speedZ = 5;
		run.interactable = true;
		walk.interactable = false;
	}
}
