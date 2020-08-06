using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManagerCube : MonoBehaviour
{
	[SerializeField]
	CubeInteraction currentInteractableCube;


	// Update is called once per frame
	void Update()
	{
		// DetectMouseClick();
		DetectHandGestureClick();
	}


	void DetectHandGestureClick()
	{

		//All the information of the hand
		HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

		//The click happens when I perform the Click Gesture : Open Pinch -> Closed Pinch -> Open Pinch 
		if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.RELEASE_GESTURE)
		{
			//Logic that should happen when I click/release gesture
			if (currentInteractableCube)
			{
				currentInteractableCube.InteractWithCube();

			}
		}

	}


	void DetectMouseClick()
	{

		//The click happens when I release the left mouse buttons
		if (Input.GetMouseButtonUp(0))
		{

			//Logic that should happen when I click.

			if (currentInteractableCube)
			{
				currentInteractableCube.InteractWithCube();

			}

		}
	}
}