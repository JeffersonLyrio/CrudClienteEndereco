using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Models {
    public class Cliente {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string DataNascimento { get; set; }

        public void Validar() {
            
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentNullException(Nome, string.Format("O {0} é obrigatório.", nameof(Nome)));

            if (Nome.Length > 30)
                throw new Exception(string.Format("O {0}: \"{1}\" ultrapassou o limite de 30 caracteres. Possui {2} caracteres", nameof(Nome), Nome, Nome.Length));

            if(string.IsNullOrEmpty(Cpf))
                throw new ArgumentNullException(Cpf, string.Format("O {0} é obrigatório.", nameof(Cpf)));

            if (!Shared.ValidaCPF.IsCpf(Cpf))
                throw new Exception(string.Format("O {0}: \"{1}\" não é valido.", nameof(Cpf), Cpf));

            if (!Shared.ValidarData.IsData(DataNascimento))
                throw new Exception(string.Format("A {0}: \"{1}\" está no formato errado e/ou invalida. Formato esperado \"dd/MM/yyyy\"", nameof(DataNascimento), DataNascimento));
        }
    }
}
