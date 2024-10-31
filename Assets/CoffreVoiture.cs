using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class CoffreVoiture
{
    public CoffreVoiture ()
	{
		Debug. Log ("Le coffre de la voiture a été créé.");
	}
	
    public CoffreVoiture (string x)
	{
		Debug. Log
		(
			"Le coffre de la voiture a été créé avec l'argument suivant : "
			+ x
			+ "."
		);
	}
	
	~CoffreVoiture ()
	{
		Debug. Log ("Le coffre de la voiture sera maintenant détruit !");
	}
}
