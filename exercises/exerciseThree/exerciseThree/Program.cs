using System;

//-- känns som man borde ha kunnat skala ner på mycket utav koden
//-- inte jättenöjd, men verkar funka som den ska
namespace exerciseThree {
		class Program {

				//-- the array
				public static int[] wall_e = new int[10];

				static void Main() {

						//-- for loop depending on the size of the array
						for (int i = 0; i < wall_e.Length; i++) {

								string inputString;
								int inputNum;

								Console.Write("Ange tal nr {0}: ", i + 1);

								inputString = Console.ReadLine();

								//-- check input and save values; ganska simpelt
								if (int.TryParse(inputString, out inputNum)) {

										//- är prestanda superviktigt, är det då bättre att göra alla menyvalsuträckningar
										//- här samt spara högsta och lägsta tal precis så jag gjort längre ner.
										wall_e[i] = inputNum;
										Console.WriteLine("'{0}' tillagd", inputNum);
								} else {

										Console.WriteLine("'{0}' är inte en siffra", inputString);
										i--;
								}

								//-- action at the end of the for loop
								if (i + 1 == wall_e.Length) {

										Console.Write("\n" + "Välj vad du vill göra:" +
																"\n" + " 1. Visa största talet \n" +
																" 2. Visa minsta talet \n" +
																" 3. Visa medelvärdet med en decimal \n" +
																" 4. Visa alla inmatade tal \n" +
																" 5. Börja om \n" +
																" 6. Avsluta detta program \n\n");

										displayMenu();
								}
						}
				}

				static void displayMenu() {

						int menuAction;
						string displayResult = wall_e[0].ToString();

						//-- the big ifs; inte komplicerat, hoppas bara förståeligt..
						if (!int.TryParse(Console.ReadLine(), out menuAction) || menuAction < 1 || menuAction > 6) {

								Console.WriteLine("Finns inget sådant val, försök igen \n");

						} else if (menuAction == 1) {

								//- här kan man sammanfoga de tre nedre for loops. men ville att alla uträckingar
								//- sker vid interaktion.
								for (int i = 0; i < wall_e.Length; i++) {

										if (wall_e[i] > int.Parse(displayResult)) {

												displayResult = wall_e[i].ToString();
										}
								}
						} else if (menuAction == 2) {

								for (int i = 0; i < wall_e.Length; i++) {

										if (wall_e[i] < int.Parse(displayResult)) {

												displayResult = wall_e[i].ToString();
										}
								}
						} else if (menuAction == 3) {

								double sum = 0;

								for (int i = 0; i < wall_e.Length; i++) {

										sum += wall_e[i];
								}

								double average = sum / wall_e.Length;
								displayResult = $"{average:.0}";

						} else if (menuAction == 4) {

								displayResult = string.Join(", ", wall_e);

						} else if (menuAction == 5) {

								Main();

						} else if (menuAction == 6) {

								System.Environment.Exit(0);
						}

						//- visa resultat
						Console.WriteLine(displayResult + "\n");

						displayMenu();
				}
		}
}
