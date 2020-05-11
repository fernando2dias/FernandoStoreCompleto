import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Local } from "protractor/built/driverProviders";

@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router) {
    //router = new Router()
  }


  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    let autenticado = sessionStorage.getItem("usuario-autenticado");
    if (autenticado === "1") {
      return true;

    }
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    //se usuario atenticado
    return false;
  }


}
