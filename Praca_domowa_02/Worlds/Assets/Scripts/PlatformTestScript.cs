using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTestScript : MonoBehaviour
{

      public GameObject Player;
      Animator  animator;
      bool platformUp;


    // Start is called before the first frame update
    void Start()
    {
        platformUp = false;
        animator = GetComponent<Animator>();
    }


    
    void OnTriggerEnter2D(Collider2D col)
    {
    
        if (col.gameObject == Player)
        {
            platformUp = true;
            Debug.Log("Platforma na górze");
            PlatformTestControl("Up");
		}
	}

    void OnTriggerExit2D(Collider2D col)
    {
        if (platformUp)
        {
             platformUp = false;
             Debug.Log("Platforma na dole");
             PlatformTestControl("Down");
		}
        

	}

    void PlatformTestControl(string direction)
    {
        animator.SetTrigger(direction);
	}

}
