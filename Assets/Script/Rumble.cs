using UnityEngine;
using System.Collections;
using Rewired;

public class Rumble : Singleton<Rumble>
{

	//both Motor speed has to be between 0.0 and 1.0. duration in seconds.
	public void RumbleMe (int ID, float leftMotorSpeed, float rightMotorSpeed, float duration)
	{ 
		if (ID < ReInput.players.playerCount) {
			Player player = ReInput.players.GetPlayer (ID);	
			if (player != null) {
				if (player.controllers.Joysticks.Count > 0) {
					Joystick joystick = player.controllers.Joysticks [0];
					if (joystick.supportsVibration) {
						joystick.SetVibration (leftMotorSpeed, rightMotorSpeed);
						StartCoroutine (Vibrate (joystick, duration));			
					}
				}
			}
		}
	}

	IEnumerator Vibrate (Joystick joystick, float duration)
	{
		yield return new WaitForSeconds (duration);
		joystick.StopVibration ();
		yield return null;
	}
}

/*public Rumble rumble;

rumble.RumbleMe(ID, leftMotorSpeed, rightMotorSpeed, 3)*/