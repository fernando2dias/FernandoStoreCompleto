import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "cadastro-usuario",
  templateUrl: "./cadastro.usuario.component.html",
  styleUrls: ["./cadastro.usuario.component.css"]
})

export class CadastroUsuarioComponent implements OnInit {
  
  public usuario: Usuario;


  
  constructor(private usuarioServico: UsuarioServico) {

  }

  ngOnInit(): void {
    this.usuario = new Usuario();
  }


  public cadastrar() {
    //this.usuarioServico.verificarUsuario(this.usuario)
    //  .subscribe(
    //    usuarioJson => { },
    //    e => { }
    //  );

    console.log(this.usuario.nome);
    console.log(this.usuario.sobreNome);
    console.log(this.usuario.email);
    console.log(this.usuario.senha);

  }


}
