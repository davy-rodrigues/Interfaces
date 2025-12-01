 namespace Project4
{
 
 public class PagamentoViaCartao : IPagamento 
				{
					public string id {get; set; }
					public int CPF { get; set;}
					public DateTime Vencimento {get; set;}
					public DateTime EmissaoHolerite { get; set; }
					public decimal Valor {get; set; }
					public string NumeroCartao {get; set;}

				 public	 PagamentoViaCartao()
					{
					this.Vencimento = DateTime.Now.AddDays(30);
					}
					public void Pagar(decimal valor)
						{
							Console.WriteLine ($"id: {this.id}, Valor: {Valor:N2} \n  **Cartão de Crádito**, \nVencimento da fatura: {Vencimento:dd/MM/yyyy}");
						}


				}
}    

