using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class NewBehaviourScript: MonoBehaviour
{
	private CoffreVoiture
		coffre1,
		coffre2
	;
	
	
    void Start ()
    {
        CoffreVoiture coffre1 = new CoffreVoiture ();
		CoffreVoiture coffre2 = new CoffreVoiture ("bonjour tout le monde");
    }
	
    void Update ()
    {
        if (Input. GetKeyUp (KeyCode. D))
    }
}
