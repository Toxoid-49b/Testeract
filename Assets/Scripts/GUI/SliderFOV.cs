using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderFOV : MonoBehaviour {
	public Text indicator;
	public float defaultFOV = 75;
	private Slider slider;
	
	void Start () {
		slider = gameObject.GetComponent<Slider>();
		slider.value = PlayerPrefs.GetFloat("FieldOfView");
		indicator.text = PlayerPrefs.GetFloat("FieldOfView").ToString();
		slider.onValueChanged.AddListener(OnSliderChanged);
	}
	void OnSliderChanged (float val) {
		PlayerPrefs.SetFloat("FieldOfView", val);
		indicator.text = val.ToString();
	}
}
