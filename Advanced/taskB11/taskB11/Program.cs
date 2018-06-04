using System;
using System.Collections;
using System.Collections.Generic;
namespace taskB11
{
	public class Hashtable<K, V>{
		int n = 0;
		K[] arrK = new K[1000];
		V[] arrV = new V[1000];
		public void put(K key, V value){
			bool ready = false;
			for (int i = 0; i < n; i++) {
				if (arrK.GetValue (i).Equals (key)) {
					ready = true;
				}
			}
			if (!ready) {
				arrK [n] = key;
				arrV [n] = value;
				n++;
			}
		}
		public V getValue(K key){
			for (int i = 0; i < arrK.Length; i++) {
				if (arrK.GetValue (i).Equals(key)) {
					return arrV [i];
				}
			}
			Console.WriteLine ("This number doesn't exist in phonebook!");
			return default(V);
		}
		public K getKey(V value){
			for (int i = 0; i < n; i++) {
				if (arrV.GetValue (i).Equals (value)) {
					return arrK [i];
				}
			}
			Console.WriteLine ("This name doesn't exist in phonebook!");
			return default(K);
		}
		public bool containsKey(K key){
			for (int i = 0; i < n; i++) {
				if (arrK.GetValue (i).Equals(key)) {
					return true;
				}
			}
			return false;
		}
		public void values(){
			for (int i = 0; i < n; i++) {
				Console.WriteLine(arrK [i] + " - " + arrV [i]);
			}
		}
		public bool isEmpty(){
			if (n == 0)
				return true;
			return false;
		}
		public void clear(){
			arrK = new K[0];
			arrV = new V[0];
			n = 0;
		}
		public int size(){
			if (n == 0) {
				Console.WriteLine ("null");
			}
			return n;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Hashtable<string, string> phonebook = new Hashtable<string, string> ();
			phonebook.put ("Aslan", "11111");
			phonebook.put ("Erlan", "22222");
			phonebook.put ("Eldana", "3333");
			phonebook.put ("Danara", "4444");
            phonebook.put("Kerim", "5555");
            Console.WriteLine ("All data in phonebook:");
			phonebook.values ();
			Console.WriteLine ("Size of phonebook: " + phonebook.size ());
			int test = 10;
			for (int i = 0; i < test; i++){
				Console.WriteLine ("\r\n1.NAME\r\n2.NUMBER");
				Console.Write ("Please, choose the number that you need: ");
				int num = int.Parse (Console.ReadLine ());
				if (num == 1) {
					Console.Write ("Enter the name: ");
					string eng = Console.ReadLine ();
					Console.WriteLine(phonebook.getValue (eng));
				} else if (num == 2) {
					Console.Write ("Enter the number: ");
					string rus = Console.ReadLine ();
					Console.WriteLine(phonebook.getKey (rus));
				} else {
					Console.WriteLine ("Please, enter only 1 or 2. Try again!");
				}
			}
		}
	}
}
