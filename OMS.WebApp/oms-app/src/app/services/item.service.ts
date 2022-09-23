import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, map, Observable, throwError } from "rxjs";
import { environment } from "src/environments/environment";
import { CategoryItem } from "../models/category-item";
import { AccountService } from "./account.service";


@Injectable({
    providedIn: 'root'
  })  
  export class ItemService{

    constructor(
        private http: HttpClient,
        private accountService: AccountService
    ) {}
    
   public getItems(): Observable<CategoryItem[]> {
    debugger;
        const outleId = this.accountService.getOutletId();
        return this.http.get<CategoryItem[]>(`${environment.apiUrl}/Item/GetItems?outletId=` + outleId).
            pipe(
               map((data: CategoryItem[]) => {
                 return data;
               }), catchError( error => {
                 return throwError( 'Something went wrong!' );
               })
            )
        }
  }