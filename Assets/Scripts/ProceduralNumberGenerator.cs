using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class ProceduralNumberGenerator {
	public static int currentPosition = 0;
	private static System.Random random = new System.Random();
	public static string RandomString(int length)
	{
		const string chars = "1234";
		return new string(System.Linq.Enumerable.Repeat(chars, length)
		.Select(s => s[random.Next(s.Length)]).ToArray());
	}
	static System.Random RandomLength = new System.Random();
	static int length = RandomLength.Next(1, 100);
	public static string key = RandomString(length);

	public static int GetNextNumber() {
		string currentNum = key.Substring(currentPosition++ % key.Length, 1);
		Debug.Log(length);
		return int.Parse (currentNum);
	}
}
