﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
              Destroy(Player.gameObject, 0.1f);
		}
        
	}

    void OnTriggerExit2D(Collider2D other)
		{
			if (other.gameObject == Player)
			{
				
			}
			
		}
}