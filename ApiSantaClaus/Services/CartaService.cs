using ApiSantaClaus.Models;
using ApiSantaClaus.Validators;

namespace ApiSantaClaus.Services
{
    public static class CartaService
    {
        public static ResponseAdapter RegraCarta(Carta carta)
        {
            var validator = new CartaValidator(carta);
            var errorMsg = validator.Validate();

            var response = new ResponseAdapter();
            response.isSucess = errorMsg == null || errorMsg.Count == 0;
            response.details = errorMsg;
            response.returnBody = null;
            
            return response;
        }

        public static ResponseAdapter RegraBuscaCarta(string cidade)
        {
            var response = new ResponseAdapter();
            response.isSucess = !string.IsNullOrWhiteSpace(cidade);
            response.details = string.IsNullOrWhiteSpace(cidade) ? "Informe alguma cidade" : "";
            response.returnBody = null;

            return response;
        }
    }
}
