using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
	bool isHighlighted;

	//Feel free to choose your own colors
	public ParticleSystem particleEffect;
	public Color idleColor;
	public Color isHighliughtedColor;
	public AudioSource fireAudio;
	MeshRenderer cubeMeshRenderer;
	ParticleSystemRenderer particleRenderer;
	AudioRenderer fireaudioRenderer;
	
	// Start is called before the first frame update
	void Start()
	{
		particleRenderer = this.GetComponent<ParticleSystemRenderer>();
		fireaudioRenderer = this.GetComponent<AudioRenderer>();
		cubeMeshRenderer = this.GetComponent<MeshRenderer>();
		isHighlighted = false;
		UpdateColor();
	}

	/// <summary>
	/// Updates the cubes material color according to the status (isActivated or Not)
	/// </summary>
	private void UpdateColor()
	{
		if (isHighlighted)
		{
			particleEffect.Play();
			fireAudio.Play();
			cubeMeshRenderer.material.color = isHighliughtedColor;
		}
		else
		{
			particleEffect.Stop();
			fireAudio.Stop();
			cubeMeshRenderer.material.color = idleColor;
		}
	}
	
	/// <summary>
	/// Toggles the cubes activation value (isActive or Not)
	/// </summary>
	private void ToggleHighlight()
	{
		isHighlighted = !isHighlighted;
	}

	/// <summary>
	/// The code logic of the interaction. In our example, Toggle the status and update the visuals.
	/// </summary>
	public void InteractWithCube()
	{
		ToggleHighlight();
		UpdateColor();
	}
}

