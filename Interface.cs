
namespace Project4
{
public interface IPagamento
 
		{
			string Nome {get; set; }
			int CPF { get; set;}

            DateTime EmissaoHolerite { get; set;}

			
            DateTime Vencimento { get; set;}
            
 
			decimal Valor { get; set;}

 
			void Pagar(decimal valor);
 
		}
}