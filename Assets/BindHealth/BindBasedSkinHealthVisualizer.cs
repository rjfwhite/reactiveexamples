using UnityEngine;
using System.Collections;
using System.Threading;

public class BindBasedSkinHealthVisualizer : MonoBehaviour {
	
	public BindBasedHealthState healthState;
	public Renderer skin;
	
	void Start() {
		healthState.health.BindTo (RenderSkin);
	}
	
	void RenderSkin(float health) {
		Thread.Sleep (300);
		skin.material.color = new Color (health / 100.0f, 0.0f, 0.0f);
	}
}
