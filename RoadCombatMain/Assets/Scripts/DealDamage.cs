using UnityEngine;
using System.Collections;
using System;

public class DealDamage : MonoBehaviour {
    //public float damage = 10f;
    

	private Fighter fighter;

	void Start () {
		fighter = GetComponent<Fighter>();
	}

	public void Fire () {
		if (fighter.target == null) { return; }

        System.Random rnd = new System.Random();
        int number = rnd.Next(0, 11);

        float damage = Convert.ToSingle(number);

        fighter.target.TakeDamage(damage);
	}
}
