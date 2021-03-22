using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

	public Animator ani;
	public Transform attackPoint;
	public float  attackRange = 0.5f;
	public LayerMask enemyLayers;
	// Update is called once per frame
	void Update () {
		ani.SetBool("attack",false);
		if(Input.GetKeyDown(KeyCode.Space)){
			Atack();
		}
	}
	void Atack(){
		ani.SetBool("attack",true);
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayers);
		foreach(Collider2D enemy in hitEnemies){
			Debug.Log(	"We hit" + enemy.name);
		}
	}
	void OnDrawGizmosSelected(){
		if(attackPoint == null){
			return;
		}
		Gizmos.DrawWireSphere(attackPoint.position,attackRange);
	}
}
