import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Local } from "protractor/built/driverProviders";
import { UsuarioServico } from "../servicos/usuario/usuario.servico";

@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router, private usuarioServico: UsuarioServico) {
    //router = new Router()
  }


  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    //this.usuarioServico

    if (this.usuarioServico.usuario_autenticado()) {
      return true;
    }
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    //se usuario atenticado
    return false;
  }


}
