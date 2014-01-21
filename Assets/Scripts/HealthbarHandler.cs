using UnityEngine;
using System.Collections;

/**
 * <summary>
 * 	indica che l'elemento a cui questo script è attaccato
 *  rappresenta una HealthBar di un oggetto.
 *  Affinché lo script funzioni è necessario avere:
 *  <ul>
 * 		<li>un GameObject padre rappresentante il contorno della della healthbar</li>
 * 		<li>un GameObject figlio rappresentante la vita (esempio una barra rossa)</li>
 *  </ul>
 *  Fatto importante è che la sprite che viene mostrata come se fosse una vita viene
 * 	COMPRESSA per rappresentare la vita corrente, non viene quindi TAGLIATA
 * 
 * </summary>
 */
public class HealthbarHandler : MonoBehaviour {

	/**<summary>
	 * Indica la linea raprresentante la vita vera e propria
	 *</summary>
	 */
	public GameObject healthBarLine;
	/**
	 * <summary>
	 * rappresenta lo ScaleX della barra indicante la vita vera e propria
	 * corrispondente alla vita massima. In questo modo si ha un upper bound dello
	 * scaleX da effettuare sulla barra
	 * </summary>
	 */
	private float maxHpScale;

	// Use this for initialization
	void Start () {
		this.maxHpScale = this.healthBarLine.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void updateHealthBar(float health,float maxhealth){
		Debug.Log ("updateHealthBar("+health+","+maxhealth+")");
		//per disegnare la barra correttamente per prima cosa setto correttamente l'ampiezza
		this.healthBarLine.transform.localScale = new Vector3 (
			this.maxHpScale*(health/maxhealth),
			this.healthBarLine.transform.localScale.y,
			this.healthBarLine.transform.localScale.z
		);
		//ora dispongo la posizione corretta, ossia il punto in alto a sinistra della barra
		Debug.Log ("this.renderer.bounds.size.x: "+this.renderer.bounds.size.x);

		this.healthBarLine.transform.position=new Vector3(
			this.healthBarLine.transform.position.x,//-this.renderer.bounds.size.x,
			this.healthBarLine.transform.position.y,
			this.healthBarLine.transform.position.z
		);
	}
}
