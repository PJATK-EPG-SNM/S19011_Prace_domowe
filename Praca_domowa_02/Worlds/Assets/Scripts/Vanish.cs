using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanish : MonoBehaviour
{

	public GameObject Player;
	public float timer = 2f;
   
	private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject == Player)
			{
			Destroy(this.gameObject, timer);
//				
			
			}
		}
		
	private void OnTriggerExit2D(Collider2D other)
		{
			if (other.gameObject == Player)
			{
				
			}
			
		}
}
