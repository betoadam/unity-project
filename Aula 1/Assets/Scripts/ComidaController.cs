using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaController : MonoBehaviour {

	// Update is called once per frame
	 float duration = 1.5f;
     private float t = 0;
     private float lerp = 1;
	 public Renderer rend;
     bool isReset = false;
    private object comida;

    void Start()
	 {
		rend = GetComponent<Renderer>();
	 }
	void Update () {
		ColorChangerr();
		transform.Rotate(new Vector3(15,32,60)*Time.deltaTime);
	}
	     void ColorChangerr()
     {
         if (this.tag == "Colecionavel")
         {
                 rend.material.color = Color.Lerp(Color.yellow, Color.magenta, lerp);
                lerp = Mathf.PingPong(Time.time,duration)/duration;
                
            
             
         }
             
     }
}
