using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Viewable<T> {
	private IList<Action<T>> actions = new List<Action<T>> ();

	private T value;

	public void BindTo(Action<T> action) {
		actions.Add (action);
		action.Invoke (value);
	}

	public void Update(T newValue) {
		value = newValue;
		foreach(var action in actions) {
			action.Invoke(value);
		}	
	}
}
