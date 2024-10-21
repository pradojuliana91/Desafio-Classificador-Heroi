// See https://aka.ms/new-console-template for more information
Console.Write("Digite o nome do herói: ");
string nomeHeroi = Console.ReadLine();

Console.Write("Digite a quantidade de XP do herói: ");
int xpHeroi = Convert.ToInt32(Console.ReadLine());

string nivel;

int faixaXp = xpHeroi switch 
{
	< 1000 => 1,
	<= 2000 => 2,
	<= 5000 => 3,
	<= 7000 => 4,
	<= 8000 => 5,
	<= 9000 => 6,
	<= 10000 => 7,
	_ => 8
};

switch (faixaXp)
		{
			case 1:
				nivel = "Ferro";
				break;
			case 2:
				nivel = "Bronze";
				break;
			case 3:
				nivel = "Prata";
				break;
			case 4:
				nivel = "Ouro";
				break;
			case 5:
				nivel = "Platina";
				break;
			case 6:
				nivel = "Ascendente";
				break;
			case 7:
				nivel = "Imortal";
				break;
			default:
				nivel = "Radiante";
				break;
		}
		
Console.WriteLine($"O Herói de nome {nomeHeroi} está no nível de {nivel}.");
