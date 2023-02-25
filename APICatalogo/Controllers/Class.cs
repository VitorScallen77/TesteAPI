using APICatalogo.Models;

public class ProdutoRepository {
    private readonly List<Produto> _produtos;

    public ProdutoRepository() {
        _produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto 1", Descricao = "Descrição do Produto 1", Preco = 10.50m, Quantidade = 20 },
            new Produto { Id = 2, Nome = "Produto 2", Descricao = "Descrição do Produto 2", Preco = 15.75m, Quantidade = 15 },
            new Produto { Id = 3, Nome = "Produto 3", Descricao = "Descrição do Produto 3", Preco = 7.90m, Quantidade = 30 }
        };
    }

    public IEnumerable<Produto> GetAll() {
        return _produtos;
    }

    public Produto GetById(int id) {
        return _produtos.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Produto produto) {
        produto.Id = _produtos.Count + 1;
        _produtos.Add(produto);
    }

    public void Update(Produto produto) {
        var index = _produtos.FindIndex(p => p.Id == produto.Id);
        if (index != -1) {
            _produtos[index] = produto;
        }
    }

    public void Delete(int id) {
        var produto = GetById(id);
        if (produto != null) {
            _produtos.Remove(produto);
        }
    }
}
