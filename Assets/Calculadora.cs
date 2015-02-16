using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Calculadora : MonoBehaviour {
	public int Number1;
	public int Number2;
	
	// Use this for initialization
	void Start () {
		Addition(Number1,Number2);
	}
	
	public void Addition(int Number1, int Number2){
		int Result = Number1 + Number2;
		print ("La suma de los numeros es: " + Result);
		IntToRomanConverter (Result);
	}
	
	public void IntToRomanConverter(int Result){
		var RomanValue = new StringBuilder(5);
		var IntToRomanDirectory = new SortedDictionary<int, string>
		{
			{ 1, "I" },
			{ 4, "IV" },
			{ 5, "V" },
			{ 9, "IX" },
			{ 10, "X" },
			{ 40, "XL" },
			{ 50, "L" },
			{ 90, "XC" },
			{ 100, "C" },
			{ 400, "CD" },
			{ 500, "D" },
			{ 900, "CM" },
			{ 1000, "M" },
		};
		
		foreach (var kvp in IntToRomanDirectory.Reverse())
		{
			while (Result >= kvp.Key)
			{
				Result -= kvp.Key;
				RomanValue.Append(kvp.Value);
			}
		}
		print("Y en numeros romanos es: "+RomanValue);
	}
}
