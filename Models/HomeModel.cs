namespace meuprimeiroprojeto.Models
{
    public class HomeModel
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public HomeModel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
