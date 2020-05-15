import { Component, OnInit } from "@angular/core"
import { Produto } from "../model/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]

})
export class ProdutoComponent implements OnInit {
  public produto: Produto
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;
  public mensagem: string;

  constructor(private produtoServico: ProdutoServico) {

  }
  ngOnInit(): void {
    this.produto = new Produto();
  }

  public teste() {
    console.log("teste do teste");
  }

  public inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.ativar_spinner = true;
    this.produtoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        nomeArquivo => {
          this.produto.nomaArquivo = nomeArquivo;
          console.log(nomeArquivo);
          this.ativar_spinner = false;
        },
        e => {
          this.mensagem = (e.error);
          this.ativar_spinner = false;
        });
  }

  public cadastrar() {
    this.ativar_spinner = true;
    this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);
          this.ativar_spinner = false;
        },
        e => {
          this.mensagem = e.error;
          this.ativar_spinner = false;
          console.log(e.error);
        }
      );
  }


  



}



