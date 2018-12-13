using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;
public class EscolheCarro : MonoBehaviour {
		public void EscolheOpala()
		{
			string path = "Assets/Resources/test.txt";

			//Write some text to the test.txt file
			StreamWriter writer = new StreamWriter(path, false);
			writer.WriteLine("1");
			writer.Close();
			SceneManager.LoadScene("Game");

		}
		public void EscolheSupra()
		{
			string path = "Assets/Resources/test.txt";

			//Write some text to the test.txt file
			StreamWriter writer = new StreamWriter(path, false);
			writer.WriteLine("2");
			writer.Close();
			SceneManager.LoadScene("Game");

		}
		public void EscolheNSX()
		{
			string path = "Assets/Resources/test.txt";

			//Write some text to the test.txt file
			StreamWriter writer = new StreamWriter(path, false);
			writer.WriteLine("3");
			writer.Close();
			SceneManager.LoadScene("Game");

		}
		public void EscolheSkyline()
		{
			string path = "Assets/Resources/test.txt";

			//Write some text to the test.txt file
			StreamWriter writer = new StreamWriter(path, false);
			writer.WriteLine("4");
			writer.Close();
			SceneManager.LoadScene("Game");

		}
		public void ReadString()
		{
			string path = "Assets/Resources/test.txt";

			//Read the text from directly from the test.txt file
			StreamReader reader = new StreamReader(path); 
			Debug.Log(reader.ReadToEnd());
			reader.Close();

		}

	
}