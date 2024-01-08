using System.Text;
using desafio_hotel_DIO.models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new ();

Pessoa p1 = new("Victor", "Faria");
Pessoa p2 = new("Icaro", "Faria");
// Pessoa p3 = new("Linda", "Souza");

hospedes.Add(p1);
hospedes.Add(p2);
// hospedes.Add(p3);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");