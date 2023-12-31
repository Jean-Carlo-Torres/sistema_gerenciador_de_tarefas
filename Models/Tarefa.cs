
using System.Text.Json.Serialization;

namespace projeto.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EnumStatusTarefa Status { get; set; }
    }

    
}