namespace Project4
{
public class Program
		{
 
				static void Main (string [] args)
						{

 
				
 
									Action<string> imprimir =(texto)=> Console.WriteLine(texto);
 
 
							 imprimir (" Efetue o Pagamento em dinheiro");
 
							 var pagamento = new Pagamento {Nome = "Naiane da Silva dos Santos", Valor = 99.00m,};
 
							 imprimir($"\n Iniciando Pagamento {pagamento.Nome}");
 
								pagamento.Pagar(pagamento.Valor);
 
 
							 var pagamentoViaCc = new PagamentoViaCartao {Nome = "João Silva Richard ",Valor = 150.75m,NumeroCartao = "1234434/35/5678" };
 
								imprimir($"\n Iniciando pagamento via Cartão para {pagamentoViaCc.Nome}");
 
								pagamentoViaCc.Pagar(pagamentoViaCc.Valor);
 
 
 
						}

		}		
}

