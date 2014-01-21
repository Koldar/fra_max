using UnityEngine;
using System.Collections;

/**<summary>
 * L'oggetto che detiene questo script possiede un'arma generica e può quindi sparare.
 * Come fa a sparare? non è compito dell'arma stabilire come.
 * Altro fatto è che un'arma non deve per forza sparare proiettili ma può benissimo
 * essere anche di mischia.
 * Se l'arma possiede eventuali proiettili, essi devono essere attaccati ad un GameObject figlio del GameObject detenente l'arma. Tale figlio deve quindi avere
 * come componenti:
 * <ul>
 *  	<li>Shot</li>
 * 		<li>Move</li>
 * </ul>
 * </summary>
 */
public abstract class Weapon : MonoBehaviour {

	/**<summary>
	 * indica il quanto velocemente un'arma è in grado di sparare.
	 * </summary>
	 */
	public float FiringRate=1.5f;

	private float CoolDownTimer;

	// Use this for initialization
	void Start () {
		this.CoolDownTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		this.updateCoolDown ();
	}

	/**<summary>
	 * Esegui questo metodo se intendi che il detentore di questo componente cerchi di sparare
	 * con questa particolare arma. Non è detto che a questa azione corrisponda un attacco:
	 * potrebbe darsi infatti che l'arma sia ancor ain cooldown
	 * </summary>
	 */
	public void requestAttack(){
		if (this.canAttack()){

		}
	}

	private void updateCoolDown(){
		if (this.CoolDownTimer > 0f) {
			this.CoolDownTimer -= Time.deltaTime;
		}
	}

	private bool canAttack(){
		return this.CoolDownTimer <= 0f;
	}

	/** <summary>
	 * Effettua un vero e proprio attacco con questa arma
	 * </summary>
	 */
	abstract public void Attack ();
}
