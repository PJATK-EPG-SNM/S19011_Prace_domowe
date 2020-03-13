using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanish : MonoBehaviour
{

	public float timer = 2f;
	public GameObject Player;
	
//	private float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	
		
//        if (timer > 0)
//			{
//				timer -= Time.deltaTime;
//				if (timer <= 0)
//				{
//				 Destruction();
//				}
//			}
    }
	
	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Player"){
//			if (timer > 0)
//			{
//				timer -= Time.deltaTime;
//				if (timer <= 0)
//				{
				 Destruction();
//				}
//			}
			
		}
	}
	
//	private void OnTriggerEnter(Collider other)
//	{
//		if (other.gameObject == Player)
//		{
////			if (timer > 0)
////			{
////				timer -= Time.deltaTime;
////				if (timer <= 0)
////				{
//				 Destruction();
////				}
////			}
//		}
//	}
	
	void Destruction()
	{
		Destroy(this.gameObject);
	}
}
