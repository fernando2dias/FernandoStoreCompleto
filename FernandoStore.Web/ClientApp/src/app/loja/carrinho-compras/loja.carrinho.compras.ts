import { Produto } from "../../model/produto";

export class LojaCarrinhoCompras {
  public produtos: Produto[] = [];


  public adicionar(produto: Produto) {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");

    if (!produtoLocalStorage) {
      //se nao existir nada dentro do localStorage
      this.produtos.push(produto);
    } else {
      // se ja existir pelo menos um unico item na sessa localStorage
      this.produtos = JSON.parse(produtoLocalStorage);
      this.produtos.push(produto);
     
    }
    localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
  }

  public obterProdutos(): Produto[] {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (produtoLocalStorage) {
      return JSON.parse(produtoLocalStorage);
    }

  }

  public removerProduto(produto: Produto) {


  }

}