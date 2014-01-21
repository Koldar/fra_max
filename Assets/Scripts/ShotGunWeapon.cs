using UnityEngine;
using System.Collections;

public class ShotGunWeapon : Weapon {

	/**<summary>
	 * indica il modello dello sparo che questa arma è in grado di sparare
	 * </summary>
	 */
	public GameObject shotModel;

	override public void Attack(){

		var shot = GameObject.Instantiate (shotModel)as GameObject;

		shot.transform.position = this.transform.position;

		//eventualmente posso prendere gli shot sparabili dall'arma
		//Shot shotytpe = this.GetComponentInChildren<Shot> ();

		//ora associo un movimento allo sparo
		Move shotMovement = shot.gameObject.GetComponent<Move> ();
		if (shotMovement != null) {
			shotMovement.direction = this.transform.right;
		}

	}

}
