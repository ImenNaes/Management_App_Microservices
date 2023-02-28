import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators,FormGroup, FormControl  } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/Models/product.model';
import { SahredServiceService } from 'src/app/Services/sahred-service.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit{
  /**
   *
   */
  public product!: Product;
  products: any;
  prodid!: string;
  prodname!:string;
  description!: string;
  reactivForm!: FormGroup;

  constructor(private service: SahredServiceService, private route: ActivatedRoute, private router: Router) { 
  }

  ngOnInit(): void {
    this.initForm();
    this.GetAll();
  }
  
  initForm() {
    this.reactivForm= new FormGroup({
      Id: new FormControl(null), 
      Name: new FormControl(null), 
      Description: new FormControl(null)
    });
  }

  GetAll(){
    this.service.GetList().subscribe(
      res=>{
        this.products=res;  
      }
    )
  }

  AddProduct(){
    console.log(this.reactivForm.value);
    var objproduct = {
      Name: this.prodname, 
      Description: this.description
    }

    this.service.AddProduct(this.reactivForm.value).subscribe(res=>{
       this.GetAll()
    });
  }

  EditProduct(id: number){
     this.service.Update(id).subscribe(
         result=>{
             console.log(result);
         }
     );
  }

  DeleteProduct(id: number): void{

     this.service.DeleteProd(id).subscribe(
      response => {
        this.GetAll()
        //this.router.navigate(['/Products']);
      },
      error => {
        console.log(error);
      });    
  }

}
