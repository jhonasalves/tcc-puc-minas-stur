using System;

namespace STUR
{
    public class ImpostoTerritorial : IImpostoTerritorial
    {
        public ImpostoDTO ConsultarImpostoTerritorial(int identificacaolImovel, string documento)
        {

            return new ImpostoDTO {
                Documento = documento,
                IdentificacaoImovel = identificacaolImovel,
                AnoExercicio = DateTime.Now.Year,
                Valor = new Random().Next(100, 1000),
                Endereco = new EnderecoDTO
                {
                    Cep = "12345789",
                    Endereco = "Av. Brasil",
                    Bairro = "Centro",
                    Numero = "123",
                    Complemento = ""
                }
            };
        }


    }
}
