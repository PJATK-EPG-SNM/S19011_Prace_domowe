using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ZAD 1
        int li1 = 10;
        float li2 = 5.5f;

        //ZAD 2
        bool log1 = true;
        bool log2 = false;

        //ZAD 3
        string str1 = "Programuję w C#";
        string str2 = "EPG";

        //ZAD 4
        Debug.Log("li1 = " + li1 + ", li2 = " + li2 + "// log1 = " + log1 + ", log2 = " + log2 + "// str1 = " + str1 + ", str2 = " + str2);


        //ZAD 5
        Zad5();
    

        //ZAD 6
        Zad6();
        

        //ZAD 7
        Zad7();


        //ZAD 8
        void Zad5()
        {
              if (li1 == li2)
              {
                    Debug.Log("Tak");
              } else
              {
                    Debug.Log("Nie");
              }
	
              if (li1 != li2)
              {
                    Debug.Log("Tak");
              } else
              {
                    Debug.Log("Nie");
		      }  

              if ((li1 > li2) || (li1 >= li2) || (li1 < li2) || (li1 <= li2))
              {
                    Debug.Log("Tak");
              } else
              {
                    Debug.Log("Nie");
		      }
		}

        void Zad6()
        {
                bool result = str1.Equals(str2);
       
                if (result == false)
                {
                     Debug.Log("różne");
		        }
		}

        void Zad7()
        {
                if (log1 == true && log2 == false)
                {
                     Debug.Log("true");  
		        }

                if (log1 == true || log2 == false)
                {
                     Debug.Log("true");  
		        }
		}

        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
