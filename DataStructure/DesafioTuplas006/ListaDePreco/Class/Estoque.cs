using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ListaDePreco.Class
{
    internal class Estoque
    {
        List<Produto> produtos = new List<Produto>();
        

        public Estoque()
        {
            LoadData();
        }

        public void SetId(Produto produto)
        {
            var AllProdutcts = produtos.Count();
            if(AllProdutcts == 0)
            {
                produto.Id = 1;
            }
            else
            {
                produto.Id = produtos.Max(x => x.Id) + 1;
            }
        }

        public void AddProduct(Produto produto)
        {
            SetId(produto);
            produtos.Add(produto);
            SaveData();
        }
        public void RemoveProduct(int id)
        {   
            var produtoEncontrado = produtos.FirstOrDefault(p => p.Id == id);
            
            if(produtoEncontrado != null)
            {
                
                produtos.Remove(produtoEncontrado);
                SaveData();
            }
            else
            {
                throw new Exception("Produto nao encontrado com esse ID");
            }
        }
        public void EditProduct(int id, string newName, decimal newValue)
        {
            try
            {
                var produtoEncontrado = produtos.FirstOrDefault(p => p.Id == id);
                if(produtoEncontrado != null)
                {
                    produtoEncontrado.Nome = newName;
                    produtoEncontrado.Preco = newValue;

                    SaveData();
                
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
        public List<string> SeeAllProducts()
        {
            List<string> list = new List<string>();
            foreach(Produto produto in produtos)
            {
                list.Add($"{produto.Id.ToString().PadLeft(3)} - {produto.Nome.PadRight(40, '.')}{produto.Preco:C}");
            }
            return list;
            
        }
        public void SaveData()
        {
            string pasta = @"C:\Users\heito\Documents\Estudos\Logica-de-Programacao\DataStructure\DataStructure\DesafioTuplas006\ListaDePreco";
            string arquivo = "produtos.csv";
            
            string caminhoArquivo = Path.Combine(pasta, arquivo);
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                {
                    foreach(Produto p in produtos)
                    {
                        string linha = $"{p.Id};{p.Nome};{p.Preco}";
                        sw.WriteLine(linha);
                    }
                }
                Console.WriteLine("Dados salvos com sucesso!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("O Erro do caminho especificado nao existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar arquivo{ex.Message}");
            }
        
        }
        public void LoadData()
        {
            string pasta = @"C:\Users\heito\Documents\Estudos\Logica-de-Programacao\DataStructure\DataStructure\DesafioTuplas006\ListaDePreco";
            string arquivo = "produtos.csv";

            string caminhoArquivo = Path.Combine(pasta, arquivo);
            if (!File.Exists(caminhoArquivo))
            {
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string linha;

                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');

                        int id = int.Parse(dados[0].PadLeft(3));
                        string nome = dados[1];
                        decimal preco = decimal.Parse(dados[2]);

                        Produto p = new Produto(id, nome, preco);
                        produtos.Add(p);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro ao carregar dados{ex.Message}");
            }

        }
    }
}
