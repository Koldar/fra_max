using UnityEngine;
using System.Collections;

/**<summary>
 * I GameObject che hanno componente questo script sono gameObject pilotabili da una persona.</br>
 * Per utilizzare anche le animazioni è necessario che il GameObject in questione abbia almeno
 * un componente Animator tra i suoi componenti. Affinché gli input dell'utente corrispondano in modo
 * corretto all'eventuale animazioni è necessario impostare:
 * <ul>
 *  <li>0 per la sinsitra</li>
 *  <li>1 per su</li>
 *  <li>2 per giu</li>
 *  <li>3 per la destra </li>
 * </summary>
 */ 
public class PlayerAnimationController : MonoBehaviour {

	private const int LEFT = 0;
	private const int UP = 1;
	private const int DOWN = 2;
	private const int RIGHT= 3;


	public string parameterName="Direction";

	private Animator animator;
	private bool hasAnimator;

	// Use this for initialization
	void Start () {
		this.animator = this.GetComponent<Animator> ();
		this.hasAnimator = (this.animator == null) ? false : true;
	}
	
	// Update is called once per frame
	void Update () {
		var inputX = Input.GetAxis ("Horizontal");
		var inputY = Input.GetAxis ("Vertical");

		if (inputX > 0) {
			this.animator.SetInteger (this.parameterName, RIGHT);
		} else {
			if (inputX < 0) {
				this.animator.SetInteger (this.parameterName, LEFT);
			} else {
				if (inputY > 0) {
					this.animator.SetInteger (this.parameterName, UP);
				} else {
					if (inputY < 0) {
						this.animator.SetInteger (this.parameterName, DOWN);
					}
				}
			}
		}

	}



}
