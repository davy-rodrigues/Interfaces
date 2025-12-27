using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
public class Pagamento : IPagamento

				{
					public string Nome {get; set; } // antes era string User 
					public int CPF { get; set;}
					public DateTime Vencimento {get; set;}
                   
                    public DateTime EmissaoHolerite { get; set; }   
 
					public decimal Valor {get; set; }

					 public Pagamento() =>this.Vencimento = DateTime.Now.AddDays(60);
					 

						public void Pagar (decimal valor)
						{ 
							Console.WriteLine ($"Nome: {this.Nome} \n Valor: {Valor:N2} \n **Dinheiro** \n Vencimento da fatura: {Vencimento:dd/MM/yyyy}");
 
						}

                }
}