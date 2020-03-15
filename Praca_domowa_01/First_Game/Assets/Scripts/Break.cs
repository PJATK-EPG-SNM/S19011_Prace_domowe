using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject Player;
	public string anname = "Platform_Break";
	
	
	private Animation an;
   
	void Start()
	{
		an = gameObject.GetComponent<Animation>();
	}
	
	
	private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject == Player)
			{
				an.Play(anname);
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
