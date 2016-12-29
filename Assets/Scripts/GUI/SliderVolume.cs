using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderVolume : MonoBehaviour {
	public Text indicator;
	public float defaultVolume = 100;
	private Slider slider;
	
	// Use this for initialization
	void Start () {

		slider = gameObject.GetComponent<Slider>();
		slider.value = PlayerPrefs.GetFloat("Volume");
		indicator.text = PlayerPrefs.GetFloat("Volume").ToString();
		slider.onValueChanged.AddListener(OnSliderChanged);
	}
	void OnSliderChanged (float val) {
		PlayerPrefs.SetFloat("Volume", val);
		indicator.text = val.ToString();
	}
}
