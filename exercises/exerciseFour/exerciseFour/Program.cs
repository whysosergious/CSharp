using System;
using System.Windows.Forms;

namespace exerciseFour {
		class Program {

				static void Main() {
						
						//-- konverterar input till en character array så att jag kan modifiera individuella tecken
						char[] inputArray = Console.ReadLine().ToCharArray();
						string cryptedInput = "";

						//-- kolla så att inputen är inte tom
						if (inputArray.Length > 0) {
								inputString(inputArray);
								cryptedInput = switchLetters(inputArray);
						}
						
						//-- skriv krypterad resultat till konsol
						Console.WriteLine(cryptedInput + "\n");

						Main();
				}

				//-- jag vet inte om jag förstod den här delen rätt
				//-- dvs om det var jag som skulle sätta ett '*' mellan varje tecken
				static void inputString(char[] arg) {
						Console.WriteLine("*{0}*", string.Join("*", arg));
				}

				static string switchLetters(char[] arg) {
						string result;

						//-- loopa igenom alla input tecken
						for (int i = 0; i < arg.Length; i++) {
								//-- kolla om tecknet är en 'z', om så omvandla till 'a'
								if ((int)arg[i] != 122) {
										arg[i] = (char)((int)arg[i] + 1);
								} else {
										arg[i] = (char)97;
								}
						}

						//-- konvertera omvandlade argumenten till sträng
						result = string.Join("", arg);

						return result;
				}
		}
}
