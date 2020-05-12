import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public mensagem: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioSevico: UsuarioServico) {


  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }



  entrar() {

    this.usuarioSevico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {

          this.usuarioSevico.usuario = usuario_json
          // essa linha sera executada no caso do retorno sem erros
             
          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
        }
      );


    //if (this.usuario.email == "fernando@teste.com" && this.usuario.senha == "abc123") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
    //}
  }



}
