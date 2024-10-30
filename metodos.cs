using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
	public class metodos

	//Criação da classe produto, suas propriedades e um construtor.
	public class Produto
	{

		public string Nome { get; set; }
		public string Preço { get; set; }

		public Produto(string nome, string preco)
		{
			this.Nome = nome;
			this.Preço = preco;
		}
	}
}
