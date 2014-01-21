using UnityEngine;
using System.Collections;

/**<summary>
 *  abbina questo script ad un GameObject se vuoi che esso possieda una vita.
 * </summary>
 */
public class Health : MonoBehaviour {

	/**<summary>
	 * Indica la vita attuale rimanente al GameObject corrente
	 * </summary>
	 */
	private float HP;
	/**<summary>
	 *  Indica la massima vita che il GameObject possiede
	 * </summary>
	 */
	public float maxHP=100;
	/**<summary>
	 *  se presente, indica la barra della vita che ha il GameObject di riferimento
	 * </summary>
	 */
	public HealthbarHandler healthBar;



	// Use this for initialization
	void Start () {
		this.HP = this.maxHP;
	}

	public bool isDead(){
		return this.HP <= 0;
	}

	public bool isAlive(){
		return this.HP > 0;
	}

	public bool hasHealthBar(){
		return this.healthBar != null;
	}

	public float substractHP(float _hp){
		this.HP -= _hp;
		if (this.HP < 0) {
			this.HP = 0;
		}
		if (this.hasHealthBar()) {
			Debug.Log ("qwertyuiop");
			this.healthBar.updateHealthBar (this.HP,this.maxHP);
		}
		return this.HP;
	}

	public float addHP(float _hp){
		this.HP += _hp;
		if (this.HP > this.maxHP) {
			this.HP = this.maxHP;
		}
		if (this.hasHealthBar()) {
			this.healthBar.updateHealthBar (this.HP,this.maxHP);
		}
		return this.HP;
	}

	public float setHP(float _hp){
		this.HP = _hp;
		if (this.HP > this.maxHP) {
			this.HP = this.maxHP;
		}
		if (this.HP < 0) {
			this.HP = 0;
		}
		if (this.hasHealthBar ()) {
			this.healthBar.updateHealthBar (this.HP, this.maxHP);
		}
		return this.HP;
	}
}
