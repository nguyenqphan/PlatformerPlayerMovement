using UnityEngine;
using System.Collections;

public class PowerUpFlower : Collectable {

	public int itemId = 1;

	override protected void OnCollect(GameObject target){

		var equipBehavior = target.GetComponent <Equip>();
		if(equipBehavior != null){
			equipBehavior.currentItem = itemId;
		}
	}
}
