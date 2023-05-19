// Instância do objeto carrinho
using Projeto_Produto_Interface;

Carrinho carrinho = new Carrinho();

// Instanciar objetos da classe Produto
Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroid Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza Horizon", 100f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção de um item");

carrinho.Remover(p2);

carrinho.Listar();

carrinho.TotalCarrinho();

Produto _novoProduto = new Produto();
_novoProduto.Nome = "FIFA 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();
carrinho.TotalCarrinho();