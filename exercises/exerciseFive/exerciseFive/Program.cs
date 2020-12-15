using System;

//-- inget nytt är :)
namespace exerciseFive {
		class Program {
				static void Main(string[] args) {
						//-- stycke direkt från uppgiftssidan
						Bil fiat = new Bil();
						fiat.setYear(2017);
						Console.WriteLine("Har nu skaffat mig en bil av " + fiat.getYear() + " års modell");
						Console.WriteLine(fiat.status());
						Console.WriteLine("Försöker starta bilen");
						fiat.start();
						Console.WriteLine("Måste kolla om du kom igång... " + fiat.status());
						Console.WriteLine("Försöker få stopp på bilen");
						fiat.stop();
						Console.WriteLine("Ska se om jag lyckades stanna den också... " + fiat.status() + "\n");
						//-- alternativ sätt för att uppdatera variabler i objekt.
						fiat.Year = 2018;
						Console.WriteLine("Har nu skaffat mig en ny bil av " + fiat.Year + " års modell");
						Console.ReadKey();
				}

				//-- skapande av klass
				class Bil {
						//-- interna klass variabler
						private int year;
						private string state = "Bilen står stilla";

						//-- klass metoder
						public void setYear(int arg) {
								year = arg;
						}
						public int getYear() {
								return year;
						}
						//-- alternativ uppdateringssätt
						public int Year {
								set {
										year = value;
								}
								get {
										return year;
								}
						}
						public string status() {
								return state;
						}
						public void start() {
								state = "Bilen kör";
						}
						public void stop() {
								state = "Bilen står stilla";
						}
				}
		}
}
