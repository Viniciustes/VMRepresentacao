namespace VMRepresentacao.Domain.Entities
{
    public class Test
    {
        public string Nome { get; set; }
        public EmailX Email { get; set; }
    }

    public class EmailX
    {
        public string EnderecoEmail { get; set; }
    }
}
