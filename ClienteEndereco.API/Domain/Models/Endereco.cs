using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Models {
    public class Endereco {
        public int Id { get; set; }
        public string Logradura { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public void Validar() {
            
            if (string.IsNullOrEmpty(Logradura))
                throw new ArgumentNullException(Logradura, string.Format("A {0} é obrigatória.",nameof(Logradura)));

            if (Logradura.Length > 50)
                throw new Exception(string.Format("A {0}: \"{1}\" ultrapassou o limite de 50 caracteres. Possui {2} caracteres", nameof(Logradura), Logradura, Logradura.Length));

            if (string.IsNullOrEmpty(Bairro))
                throw new ArgumentNullException(Bairro, string.Format("O {0} é obrigatório.", nameof(Bairro)));

            if (Bairro.Length > 40)
                throw new Exception(string.Format("O {0}: \"{1}\" ultrapassou o limite de 40 caracteres. Possui {2} caracteres", nameof(Bairro), Bairro, Bairro.Length));

            if (string.IsNullOrEmpty(Cidade))
                throw new ArgumentNullException(Cidade, string.Format("A {0} é obrigatória.", nameof(Cidade)));

            if (Cidade.Length > 40)
                throw new Exception(string.Format("A {0}: \"{1}\" ultrapassou o limite de 40 caracteres. Possui {2} caracteres", nameof(Cidade), Cidade, Cidade.Length));

            if (string.IsNullOrEmpty(Estado))
                throw new ArgumentNullException(Estado, string.Format("O {0} é obrigatória.", nameof(Estado)));

            if (Estado.Length > 40)
                throw new Exception(string.Format("O {0}: \"{1}\" ultrapassou o limite de 40 caracteres. Possui {2} caracteres", nameof(Estado), Estado, Estado.Length));
        }
    }
}
