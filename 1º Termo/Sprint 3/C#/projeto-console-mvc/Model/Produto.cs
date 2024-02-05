
namespace projeto_console_mvc.Model
{
    public class Produto
    {
        //propiedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";

        //criar um construtor
        public Produto()
        {
            //caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se existe a pasta, se nao criar
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            //verificar se existe o arquivo, se nao criar
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //arrays de string que recebe cada linha do crv.
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //antes do split
                //001;Coca;6,50

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");
                //atributo[0] = Codigo
                //atributo[1] = Nome
                //atributo[2] = Preço

                //instancia do produto
                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//Coca
                p.Preco = float.Parse(atributos[2]);//6,50f

                produtos.Add(p);
            }
            return produtos;
        }

        public string PrepararLinhasCSV(Produto p)
        {
           return $"{p.Codigo};{p.Nome};{p.Preco}"; 
        }

        public void Inserir(Produto p)
        {
            //array que vai armazenar as linhas (cada "objeto")
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }

    }
}