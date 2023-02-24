import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SahredServiceService {

  //readonly Apiurl= "https://localhost:7003/api"; 
  readonly Apiurl = "https://localhost:7003/api";  

  constructor(private http: HttpClient) {}

  GetList():Observable<any[]>{
    
    return this.http.get<any>(this.Apiurl+'/Products')
  }

  AddProduct(val:any){
    console.log("OK");
    return this.http.post("https://localhost:7003/api",val)
  }


  DeleteProd(id:any): Observable<any>{
  //  return this.http.delete('${http://localhost:5000/api/Products/}${id}')
    return this.http.delete(`${this.Apiurl + '/Products'}/${id}`);


  }

  Update(id:any,data:any): Observable<any>{
    
      return this.http.put(`${this.Apiurl + '/Products'}/${id}`, data); 
  
    }



}
