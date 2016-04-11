using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {
	
	public GameObject textBox;
	
	public Text theText;
	
	public TextAsset textFiles;
	public string [] textLines;
	
	public int currentLine;
	public int endAtLine;

	
	
	
	void Start () {
		
		if (textFiles != null) {
			
			textLines = (textFiles.text.Split ('\n'));
			
		}
		if (endAtLine == 0) {
			
			endAtLine = textLines.Length - 1;
			
		}
		
	}
	void Update(){
		
		theText.text = textLines [currentLine];
		
		if (Input.GetKeyDown ("joystick button 0") || Input.GetKeyDown("down")) {
			
			textBox.SetActive(false);
			
		}
		
	}
}
