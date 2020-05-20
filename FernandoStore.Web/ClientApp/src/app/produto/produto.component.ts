import { Component, OnInit } from "@angular/core"
import { Produto } from "../model/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Router } from "@angular/router";

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
  public cadastrado: boolean;

  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }
  ngOnInit(): void {
    var produtoSession = sessionStorage.getItem('produtoSession');

    if (produtoSession) {
      
      this.produto = JSON.parse(produtoSession);
    } else {
      console.log("2");
      this.produto = new Produto();
    }

    
    this.cadastrado = false;
  }

  

  public inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.ativar_spinner = true;
    this.produtoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        nomeArquivo => {
          this.produto.nomeArquivo = nomeArquivo;
          
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
          this.cadastrado = true;
          this.router.navigate(['/pesquisar-produto']);
        },
        e => {
          this.mensagem = e.error;
          this.ativar_spinner = false;
          console.log(e.error);
          this.cadastrado = false;
        }
      );
  }


  



}



