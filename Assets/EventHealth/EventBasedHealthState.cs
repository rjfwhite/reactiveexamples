using UnityEngine;
using System.Collections;
using System;

public class EventBasedHealthState : MonoBehaviour {
	public event Action<float> OnHealthUpdated;
	public float health;
}
