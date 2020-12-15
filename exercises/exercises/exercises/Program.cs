using System;

//---- this is so much fun!
//-- var en aning orolig över att det kanske skulle vara lite för stort skillnad
//-- mellan C# och JS med hur man går tillvägs
//-- lite trögt att komma ihåg alla olika definitioner av variabler, functioner, metoder mm
//-- men man får hoppas att det fastnar förr eller senare om man bara googlar tillräckligt många gånger
namespace exerciseOne {

		class Program {

				//-- setting program variables; å vad jag saknar JavaScripts var, let och const
				private static int maxYear = 2050;
				private static int minYear = 1950;
				private static int curYear;

				static void Main(string[] args) {
						
						//-- fetching current year
						Program.curYear = DateTime.Now.Year;

						//- kollar om det var någon event i år
						checkYear(Program.curYear.ToString());
						//- namnet på functionen förklarar nog sig själv
						waitForInput(null);
				}

				static void waitForInput(string arg) {
						
						//-- display message and wait for input; sätter ihop meddelandet med '+'
						Console.Write("Ange ett " + arg + "årtal mellan " + Program.minYear + " - " + Program.maxYear + " : ");
						string usrInput = Console.ReadLine();

						checkYear(usrInput);
						//-- måste finnas ett annat sätt att starta om funcitonen?
						waitForInput("nytt ");
				}

				static void checkYear(string arg) {
						
						//-- local variables
						int inputYear;
						string sportsEvent = "";

						//-- parse function argument; kollar samtidigt om arg innehåller något annat än siffror
						if (!int.TryParse(arg, out inputYear)) {

								//- föredrar denna typ av ihopsättning
								Console.WriteLine("'{0}' is not a number", arg);

						//-- check if given year is allowed
						} else if (inputYear >= Program.minYear && inputYear <= Program.maxYear) {

								//- shorthand if statement som ändrar böjningen på meddelandet
								string tense = inputYear >= Program.curYear ? "spelas" : "spelades";

								//- 1950 = 0, var fjärde år blir alltid 0
								//- valde denna typ av ekvation för det gör också möjligt att kolla efter 
								//- var tredje, sjunde, femtonde år osv
								if ((inputYear - Program.minYear) % 4 == 0) {
										
										//- 1994 vinter os samt f-vm sker samma år
										sportsEvent = inputYear < 1994 ? "Fotbolls VM" : "Fotbolls VM & Vinter OS";
										Console.WriteLine("år {0} {1} {2}", arg, tense, sportsEvent);
								
								//- 1952 = 2
								} else if ((inputYear - Program.minYear) % 4 == 2) {

										sportsEvent = inputYear > 1994 ? "Sommar OS" : "Sommar & Vinter OS";
										Console.WriteLine("år {0} {1} {2}", arg, tense, sportsEvent);

								} else {

										//- visa meddelandet om inget hade hänt det året
										Console.WriteLine("Inget speciellt {0} {1}", tense, arg);
								}

						} else {

								Console.WriteLine("Du verkar ha svårt att följa instruktioner");
						}
				}
		}
}

//-- säker överkomplicerade en massa, men hoppas det är åtminstone läsbart