import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Models/product.model';

@Injectable({
  providedIn: 'root'
})
export class SahredServiceService {

  //readonly Apiurl= "https://localhost:7003/api"; 
  readonly baseURL = 'https://localhost:7003/api/products';

  constructor(private http: HttpClient) {}

  GetList():Observable<any>{
    return this.http.get(this.baseURL);

    // return this.http.get<Product>("https://localhost:7003/api/Products")
         
  }
  
  AddProduct(val:any){
    console.log("OK");
    return this.http.post("https://localhost:7003/api/Products",val)
  }


  DeleteProd(id:any): Observable<any>{
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  Update(id:any): Observable<any>{
    var product = this.http.get(`${this.baseURL}/${id}`);
    return this.http.put(this.baseURL, product);
  }

}
