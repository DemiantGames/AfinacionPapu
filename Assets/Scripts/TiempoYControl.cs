using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TiempoYControl : MonoBehaviour {

	public Text TimeText;
	public float tiempo=0f;
	public int Minutos, segundos;
	public Slider slider;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		tiempo += Time.deltaTime;
		Minutos = (int)tiempo / 60;
		segundos = (int)tiempo - (Minutos * 60);
		if (segundos <= 9) {
			TimeText.text = Minutos.ToString () + ":0" + segundos.ToString ();	
		} else {
			TimeText.text = Minutos.ToString () + ":" + segundos.ToString ();
		}

		slider.value = tiempo;
	}
}