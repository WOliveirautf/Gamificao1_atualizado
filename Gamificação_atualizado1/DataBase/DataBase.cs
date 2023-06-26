using Gamificação_atualizado1.Models;
using Gamificação_atualizado1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificação_atualizado1.DataBase
{
    internal class DataBase
    {
        internal class InicializaBanco
        {
            private readonly CategoriaUI categoriaUI;
            private readonly ProdutoUI produtoUI;
            private readonly VendaUI vendaUI;
            private readonly ClienteUI clienteUI;

            public InicializaBanco(CategoriaUI categoriaUI, ProdutoUI produtoUI, VendaUI vendaUI, ClienteUI clienteUI)
            {
                this.categoriaUI = categoriaUI;
                this.produtoUI = produtoUI;
                this.vendaUI = vendaUI;
                this.clienteUI = clienteUI;
            }

            public void ExecutaInicializacao()
            {
                List<Cliente> clientes = new List<Cliente>
    {
        new Cliente { IdCliente = 1, Nome = "Gabriel", Sobrenome = "Barbosa", Endereco = "Rua A, 123", Telefone = "(11) 99999-9999" },
        new Cliente { IdCliente = 2, Nome = "Giorgian", Sobrenome = "Arascaeta", Endereco = "Rua B, 456", Telefone = "(11) 88888-8888" },
        // adicione quantos objetos Cliente quiser
    };

                // Adiciona cada objeto Cliente na lista de clientes
                foreach (Cliente cliente in clientes)
                {
                    clienteUI.RegistrarCliente(cliente);
                }

                List<Categoria> categorias = new List<Categoria>
    {
        new Categoria { IdCategoria = 1, Nome = "Categoria 1", Descricao = "Descrição da Categoria 1" },
        new Categoria { IdCategoria = 2, Nome = "Categoria 2", Descricao = "Descrição da Categoria 2" },
        // adicione quantos objetos Categoria quiser
    };

                // Adiciona cada objeto Categoria na lista de categorias
                foreach (Categoria categoria in categorias)
                {
                    categoriaUI.RegistrarCategoria(categoria);
                }

                List<Produto> produtos = new List<Produto>
    {
        new Produto { IdProduto = 1, Nome = "Bola 1", Descricao = "Jogar Futebol 1", Preco = 10.00, Categoria = categoriaUI.BuscarCategoriaPorId(1) },
        new Produto { IdProduto = 2, Nome = "Camisa 2", Descricao = "Vestir 2", Preco = 20.00, Categoria = categoriaUI.BuscarCategoriaPorId(2) },
        new Produto { IdProduto = 3, Nome = "Celular 3", Descricao = "Manter Comunicacao 3", Preco = 30.00, Categoria = categoriaUI.BuscarCategoriaPorId(1) },
        // adicione quantos objetos Produto quiser
    };

                // Adiciona cada objeto Produto na lista de produtos
                foreach (Produto produto in produtos)
                {
                    produtoUI.RegistrarProduto(produto);
                }
            }

        }
    }
}
