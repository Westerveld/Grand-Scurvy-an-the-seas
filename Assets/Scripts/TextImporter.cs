using UnityEngine;
using System.Collections;

public class TextImporter : MonoBehaviour {

	public TextAsset textFiles;
	public string[] textLines;

	void Start () {
		if (textFiles != null) {

			textLines = (textFiles.text.Split ('\n'));
	
		}
	}

}
