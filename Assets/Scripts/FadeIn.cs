using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class FadeIn : MonoBehaviour {

	public float fadeInDuration = 2f;

	private Image fadePanel;
	private Color currentColor = Color.black;


	void Start () {
		fadePanel = GetComponent<Image> ();
		fadePanel.color = currentColor;
	}
	
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInDuration) {
			float alphaChange = Time.deltaTime / fadeInDuration;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} 
		else {
			this.gameObject.SetActive (false);
		}
	}
}
