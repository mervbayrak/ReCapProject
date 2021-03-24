import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-add',
  templateUrl: './car-add.component.html',
  styleUrls: ['./car-add.component.css']
})
export class CarAddComponent implements OnInit {

  constructor(private formBuilder: FormBuilder, private carSevice: CarService, private toastrService: ToastrService) { }
  carAddForm :FormGroup;

  ngOnInit(): void {
    this.createCarAddForm();
  }

  createCarAddForm(){
     this.carAddForm = this.formBuilder.group({
       carName:["",Validators.required],
       modelYear: ["",Validators.required],
       dailyPrice:["", Validators.required],
       description:["",Validators.required]
     })
  }
  add(){
    if(this.carAddForm.valid){
      let carModel = Object.assign({},this.carAddForm.value)

      this.carSevice.add(carModel).subscribe(response=>{
        this.toastrService.success(response.message,"Başarılı")
      },responseError=>{
        if(responseError.error.Errors.length>0){
          for (let i = 0; i <responseError.error.Errors.length; i++) {
            this.toastrService.error(responseError.error.Errors[i].ErrorMessage
              ,"Doğrulama hatası")
          }       
        } 
      })
      
    }else{
      this.toastrService.error("Formunuz eksik","Dikkat")
    }
    
  }
}
