using UnityEngine;
using System.Collections;
using System.Threading;

public class BasicSkinHealthVisualizer : MonoBehaviour {

	public BasicHealthState healthState;
	public Renderer skin;

	private float currentHealth = float.NaN;

	void Update () {
		if (healthState.health != currentHealth) {
			currentHealth = healthState.health;		
			RenderSkin (currentHealth);
		}
	}

	void RenderSkin(float health) {
		Thread.Sleep (300);
		skin.material.color = new Color (health / 100.0f, 0.0f, 0.0f);
	}
}
