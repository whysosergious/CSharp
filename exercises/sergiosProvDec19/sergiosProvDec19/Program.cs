using System;

namespace sergiosProvDec19 {
		class Program {
				static void Main(string[] args) {
						
				}

				class TempClass {

						private int tempInt;
						private string tempString;

						public void setMethod(int arg) {
								tempInt = arg;
						}
						public int getMethod() {
								return tempInt;
						}
						//-- alternativ uppdateringssätt
						public int tempGetSet {
								set {
										tempInt = value;
								}
								get {
										return tempInt;
								}
						}
				}
		}
}
