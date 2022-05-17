using ProjetoPOO.src.Entities;
using static System.Console;

Knight arus = new Knight("Arus", 1, "Knight");

Wizard jenica = new Wizard("Jenica", 5, "White Wizzard");

Ninja wedge = new Ninja("Wedge", 3, "Ninja");

Wizard topapa = new Wizard("Topapa", 5, "Black Wizard");
WriteLine(arus);
WriteLine(jenica);
WriteLine(wedge);
WriteLine(topapa);

WriteLine(arus.Attack());
WriteLine(jenica.Attack(1));
WriteLine(jenica.Attack(7));
WriteLine(wedge.Attack());
WriteLine(topapa.Attack(7));

//Obs, quando se chama somente o objeto instanciado ele automaticamente utiliza do método ToString(), se sobrescrevermos esse método na classe, podemos usar desta forma para mostras as informações que queremos a respeito do objeto.