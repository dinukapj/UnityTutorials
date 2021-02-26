using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    /*
     *  Variables:
     *  
     *  string - stores text values (example: name, location, a-z, "efwefwef", "56345345", "@#$@$@@", "234234")
     *  integer (int) - 3456, 476, 5589, 23423
     *  float - 12.5, 3214.63
     *  bool (boolean) - true/false
     * 
     * */

    public bool shouldAttack;
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldAttack == true)
        {
            anim.SetBool("attack", true);
        }

        if (shouldAttack == false)
        {
            anim.SetBool("attack", false);
        }

    }


}
