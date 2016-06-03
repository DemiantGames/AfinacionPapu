using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlFrec : MonoBehaviour {
	private float TiempoSalto=8;
	private float dano=100;
	public Slider slider;

	private AudioClip c;
	public AudioSource Audio;
	private float nSamples = 8192;
	private int SamplingRate = 48000;
	float[] spectrum = new float[8192];
	public float[] FreqCentral_Notas = new float[10] {123.47f, 130.8f, 146.83f, 164.81f, 174.61f, 196f, 220f, 246.94f, 261.63f, 293.66f};
	public float[] Freq_Band = new float[8];
	public float[] Nota = new float[8];
	private float MaxSample;
	public float SingingNote = 1;
	public float FREQ;


	private int minFreq;
	private int maxFreq;
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();

		Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);
		//se carga el microfono en un audioclip, se utiliza la minima frecuencia de muestreo para no cargar el sistema
		c= Microphone.Start (null, true, 10, minFreq);


		for (int j = 0; j <= 8; j++) {

			float dif = Mathf.Abs (FreqCentral_Notas [j] - FreqCentral_Notas [j + 1]);

			Freq_Band [j] = FreqCentral_Notas [j] + dif/2;

		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {

			if (Microphone.IsRecording ("Logitech USB Microphone")) {

				StopRecording ();

			} else {

				StartRecording ();
			}
		}

		if (Microphone.IsRecording ("Logitech USB Microphone")) {

			Audio.GetSpectrumData (spectrum, 0, FFTWindow.Hamming);
			int i = 1;
			while (i < spectrum.Length - 1) {
				Debug.DrawLine (new Vector3 (Mathf.Log (i - 1), spectrum [i - 1] - 10, 1), new Vector3 (Mathf.Log (i), spectrum [i] - 10, 1), Color.green);
				i++;
			}
		}

		for (int h = 0; h <= 7; h++) {
			Nota[h] = 10 * Mathf.Log10 ((Mathf.Pow (Band_Average (Freq_Band[h], Freq_Band[h+1]), 2)));
		}

		MaxSample = Mathf.Max(spectrum);

		int z = 1;

		while (z < spectrum.Length - 1) {

			if (spectrum [z] == MaxSample) {

				FREQ = (z * 24000) / nSamples;

			}
			z++;
		}

		for (int g = 0; g <= 7; g++) {

			if (FREQ >= Freq_Band[g] && FREQ <= Freq_Band[g+1]) {

				SingingNote = g + 1;
			}

		}




		if (TiempoSalto<=0) {
			transform.position =  new Vector3 (transform.position.x, SingingNote,transform.position.z);

			TiempoSalto += 1;
		}

		TiempoSalto-=Time.deltaTime;
	}





	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Note")
		{
			dano -= 1;
			print("daño");
		}
		slider.value = dano;
	}

	void StartRecording()
	{
		c = Microphone.Start ("Logitech USB Microphone", true, 300, SamplingRate);
		while (!(Microphone.GetPosition ("Logitech USB Microphone") > 0)) {}
		Audio.PlayOneShot (c);
	}

	void StopRecording()
	{
		Microphone.End ("Logitech USB Microphone");
		GetComponent<AudioSource> ().Stop ();
	}

	float Band_Average(float Finicial, float Ffinal) {

		float n1f = Mathf.Floor (Finicial * nSamples / (SamplingRate / 2));
		int n1 = (int) n1f;
		float n2f = Mathf.Floor (Ffinal * nSamples / (SamplingRate / 2));
		int n2 = (int) n2f;
		float Band_Avg = 0;
		for (int k = n1; k <= n2; k++) {

			Band_Avg += spectrum [k];
		}

		return Band_Avg / (n2 - n1);
	}


}
