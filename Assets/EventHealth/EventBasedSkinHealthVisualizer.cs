using UnityEngine;
using System.Collections;
using System.Threading;

public class EventBasedSkinHealthVisualizer : MonoBehaviour {
	
	public EventBasedHealthState healthState;
	public Renderer skin;

	void Start() {
		RenderSkin (healthState.health);
		healthState.OnHealthUpdated += RenderSkin;
	}

	void RenderSkin(float health) {
		Thread.Sleep (300);
		skin.material.color = new Color (health / 100.0f, 0.0f, 0.0f);
	}
}
