using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	[SerializeField] public int Hp;
    public int hp {
        get { 
                return this.hp;
        }   
        set {
                this.hp = value;
        }
    }
	[SerializeField] private float speed;
	[SerializeField] private PollManager bulletPool;
	private Rigidbody2D rb;
	[SerializeField] private float coolDown;
	[SerializeField] private bool canshoot;
	

	void Start () {
		Hp = 3;
		rb = GetComponent<Rigidbody2D>();
		canshoot = true;
	}

	void Update () {
		if (Hp == 0)
		{	
			Destroy(this.gameObject);
		}

		if (Input.GetButtonUp("Fire1") && canshoot){
			bulletPool.Spawn(transform.position);
		}
	}

	IEnumerator CoolDown(){
		canshoot = false;
		yield return new WaitForSeconds(coolDown);
		canshoot = true;
	}
	void FixedUpdate() {
		rb.velocity = Vector2.right * speed * Input.GetAxisRaw("Horizontal");
		
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "TiroInimigo")
		{
			Hp--;
		}
		else if (coll.gameObject.tag == "Inimigo")
		{
			Hp = 0;
		}
	}

	
}
