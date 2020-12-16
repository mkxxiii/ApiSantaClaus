using ApiSantaClaus.Models;
using System.Collections.Generic;

namespace ApiSantaClaus.Validators
{
    public class CartaValidator
    {
        private Carta obj { get; set; }

        public CartaValidator(Carta objToValidate)
        {
            obj = objToValidate;
        }

        public List<ErrorMessage> Validate()
        {
            var errorList = new List<ErrorMessage>();
            if (obj == null)
                errorList.Add(new ErrorMessage("Informe algo"));

            if (string.IsNullOrWhiteSpace(obj.TextoCarta))
                errorList.Add(new ErrorMessage("Informe um texto de carta"));

            if (obj.Idade <= 0)
                errorList.Add(new ErrorMessage("Idade deve ser maior que 0"));

            if (string.IsNullOrWhiteSpace(obj.NomeCrianca))
                errorList.Add(new ErrorMessage("Informe um nome da crianca"));

            if (obj.Endereco == null)
                errorList.Add(new ErrorMessage("Informe um endereco"));
            else
            {
                if (string.IsNullOrWhiteSpace(obj.Endereco.Bairro))
                    errorList.Add(new ErrorMessage("Informe um bairro"));

                if (string.IsNullOrWhiteSpace(obj.Endereco.Cidade))
                    errorList.Add(new ErrorMessage("Informe uma cidade"));

                if (string.IsNullOrWhiteSpace(obj.Endereco.Estado))
                    errorList.Add(new ErrorMessage("Informe um estado"));

                if (string.IsNullOrWhiteSpace(obj.Endereco.Numero))
                    errorList.Add(new ErrorMessage("Informe um numero"));

                if (string.IsNullOrWhiteSpace(obj.Endereco.Rua))
                    errorList.Add(new ErrorMessage("Informe uma rua"));
            }

            return errorList;
        }
    }
}
