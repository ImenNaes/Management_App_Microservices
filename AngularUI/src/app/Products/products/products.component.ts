import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators,FormGroup, FormControl  } from '@angular/forms';
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
  products : any = [];
  prodid!: string;
  prodname!:string;
  description!: string;
  reactivForm!: FormGroup;

  constructor(private service: SahredServiceService) { }

  ngOnInit(): void {
    this.initForm();
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
        this.products= res;
        console.log(this.products);
      }
    )
  }

  AddProduct(){
    console.log(this.reactivForm.value);
    var objproduct = {
      Id: this.prodid,
      Name: this.prodname, 
      Description: this.description
    }

    this.service.AddProduct(this.reactivForm.value).subscribe(res=>{
       console.log(res.toString());    
   
    });
  }


}
