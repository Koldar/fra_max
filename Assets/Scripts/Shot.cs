using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	/**<summary>
	 * Indica il danno che viene dato al nemico qualora lo sparo dovesse colpire il nemico.
	 * Indica il danno BASE dell'arma, ossia quello senza modificatori.
	 * </summary>
	 */
	public float defaultDamage=1;
	/**<summary>
	 * Indica se il colpo fa male anche agli amici, non solo ai nemici
	 * </summary>
	 */
	public bool doesFriendlyFire=false;

	// Use this for initialization
	void Start () {
		DestroyObject (this.gameObject,20);
	}
}
