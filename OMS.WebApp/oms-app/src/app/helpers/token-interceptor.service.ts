import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http'
import { AccountService } from '../services/account.service';

@Injectable({
  providedIn: 'root'
})
export class TokenInterceptorService implements HttpInterceptor {
  
  constructor(private auth : AccountService) {    
  }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
  let authReq = req.clone();    
  const headers = authReq.headers
      .set('Authorization', 'Bearer ' + this.auth.getToken());
  authReq = req.clone({ headers });
  return next.handle(authReq);

}

}
