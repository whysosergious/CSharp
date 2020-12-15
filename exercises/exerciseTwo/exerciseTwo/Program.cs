using System;

namespace exerciseTwo {
		class Program {
				static void Main(string[] args) {
						
						//-- antal gånger loopen körs
						int count = 100;
						
						//-- ååh du kära for loop, vad hade man gjort utan dig
						for (int i = 0; i < count; i++) {

								//-- shorthand if fråga vid definition av en variabel.
								string nl = (i + 1) % 10 == 0 ? "\n" : null;
								Console.Write($"{i,4}" + nl);
						}
				}
		}
}

//-- är det kanske bättre att först skapa och sedan uppdatera variabler?
//-- i.e.
//-- string nl;
//-- nl = (i + 1) % 10 == 0 ? "\n" : null;
//-- inte så påläst om allokering av minne