import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { first } from 'rxjs';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  form: FormGroup = new FormGroup({});
  flag: boolean = true;
  processing = false;
  submitted = false;
  returnUrl: string = '';
   _todos = [];
   IsFailed: boolean = false;

  constructor(private router: Router, private fb: FormBuilder, private accountService: AccountService) { }
  get f() { return this.form.controls; }
  ngOnInit(): void {
    this.form = this.fb.group({
      userName: ['', [Validators.required]],
      password: ['', [Validators.required]],
    });

    this.returnUrl = '/sale';    
  }

  onSubmit(form: any) {
    //this.submitted = true;    
    this.IsFailed = false;
    // reset alerts on submit
    //this.alertService.clear();

    // stop here if form is invalid
    if (this.form.invalid) {
        return;
    }
    this.processing = true;
    this.accountService.login(this.form.get('userName')!.value, this.form.get('password')!.value)
        .pipe(first())
        .subscribe(
            data => {
                this.router.navigate([this.returnUrl]);
            },
            error => {               
              this.IsFailed = true;              
                //this.alertService.error(error);
                console.log(error);
                this.processing = false;
            });
}

}