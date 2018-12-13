using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class IniciaCena : MonoBehaviour {
	public GameObject Opala;
	public GameObject NSX;
	public GameObject Supra;
	public GameObject Skyline;
	// Use this for initialization
	void Start () {
		if(ReadString()==1){
			Opala.SetActive(true);	
		};
		if(ReadString()==2){
			Supra.SetActive(true);	
		};
		if(ReadString()==4){
			Skyline.SetActive(true);	
		};
		if(ReadString()==3){
			NSX.SetActive(true);	
		}	
	}
	
	// Update is called once per frame
	public int ReadString()
		{
			string path = "Assets/Resources/test.txt";

			//Read the text from directly from the test.txt file
			StreamReader reader = new StreamReader(path);
			var retorno = int.Parse(reader.ReadToEnd()); 
			reader.Close();
			return retorno;
			
		}
}
