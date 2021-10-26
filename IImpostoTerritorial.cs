using System.Runtime.Serialization;
using System.ServiceModel;

namespace STUR
{
    [ServiceContract]
    public interface IImpostoTerritorial
    {

        [OperationContract]
        ImpostoDTO ConsultarImpostoTerritorial(int identificacaoImovel, string documento);
    }

    [DataContract]
    public class ImpostoDTO
    {
        /// <summary>
        /// Identificação do Imóvel
        /// </summary>
        [DataMember]
        public int IdentificacaoImovel { get; set; }
        /// <summary>
        /// CPF/CNPJ
        /// </summary>
        [DataMember]
        public string Documento { get; set; }
        /// <summary>
        /// Ano de Exercicio
        /// </summary>
        [DataMember]
        public int AnoExercicio { get; set; }
        /// <summary>
        /// Valor
        /// </summary>
        [DataMember]
        public decimal Valor { get; set; }
        /// <summary>
        /// Endereço
        /// </summary>
        [DataMember]
        public EnderecoDTO Endereco { get; set; }
    }

    public class EnderecoDTO
    {
        /// <summary>
        /// CEP
        /// </summary>
        public string Cep { get; set; }
        /// <summary>
        /// Endereço
        /// </summary>
        public string Endereco { get; set; }
        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Número
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Complemento
        /// </summary>
        public string Complemento { get; set; }
    }
}
