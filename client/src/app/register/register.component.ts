// import { Component, OnInit } from '@angular/core';
// import { Router } from '@angular/router';
// import Child from 'src/models/Child';
// import { choiceArr } from 'src/models/MaleOrFemale';
// import Person from 'src/models/Person';
// import ChildService from '../child.service';
// import PersonService from '../person.service';


// @Component({
//   selector: 'app-register',
//   templateUrl: './register.component.html',
//   styleUrls: ['./register.component.scss']
// })
// export class RegisterComponent implements OnInit {
// child:Child=new Child("", "","", new Date(),"")
// constructor(public personSer:PersonService,public childSer:ChildService ){ }

// ngOnInit(): void {
// }

// saveRegisterForm(form){
// console.log(this.personSer.person)
// console.log(this.childSer.children)
// this.personSer.Add(this.personSer.person).subscribe(succ=>console.log(succ));
// for (let index = 0; index < this.childSer.children.length; index++) {
// this.childSer.children[index].idFather=this.personSer.person.TZ;
// this.childSer.Add(this.childSer.children[index]).subscribe(succ=>console.log(succ));
// }

// }
// addChild(n,d,t){
//   //this.child.ParentId=this.personSer.person.PersonId
//   this.childSer.children.push(new Child(this.child.FirstName,this.child.LastName,this.child.TZ,this.child.DateOfBirth,this.child.idFather));
//   n.value="";
//   d.value="";
//   t.value="";
// }

//   //   arr=choiceArr;
// // empty:Person=new Person(null, null, null, null, null, null, null);
// // emptyChild:Child=new Child(null, null, null, null, null);
// // person={firstName:"", lastName:""}
// //   constructor(public personService:PersonService,public routing:Router) { }
// //   addChild(){
// // this.routing.navigate(["addchild"]);
// //   }
// //   saveRegisterForm(f){
// //     this.empty=new Person(null, null, null, null, null, null, null);
// //     this.emptyChild=new Child(null, null, null, null, null);
// //   }
// }


import {
  Component,
  EventEmitter,
  OnDestroy,
  OnInit,
  Output,
  ViewChild,
} from '@angular/core';
import { FormControl, FormGroupDirective, NgForm } from '@angular/forms';
import { FormsModule, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { FloatLabelType } from '@angular/material/form-field';
import { getLocaleDateFormat } from '@angular/common';
import PersonService from '../person.service';
import ChildService from '../child.service';
import Person from 'src/models/Person';
import Child from 'src/models/Child';
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  data = [];
  // genderArr = Gender;
  // hmoArr = HMO;
  @ViewChild('myForm') form: any;
  constructor(
    public personService: PersonService,
    public childServise: ChildService
  ) {}

  resetForm(myForm: NgForm) {
    if (myForm != null) myForm.resetForm();
  }
  ngOnInit(): void {}
  
  saveRegisterForm() {
    if (
      this.checkCorrectDate(this.personService.person.DateOfBirth, new Date()) ===
      true
    ) {
      console.log('suser', this.personService.person);
      this.personService.person.Children= this.personService.children;
      if (this.form.valid) {
        console.log('uuuuu', this.personService.person);
        const find = this.personService
          .GetPerson(this.personService.person.TZ)
          .subscribe(
            (succ) => {
              if (succ === null) {
                console.log('children', this.personService.children);
                this.personService
                  .PostPerson(
                    new Person(
                      0,
                      this.personService.person.FirstName,
                      this.personService.person.LastName,
                      this.personService.person.TZ,
                      new Date(),
                      this.personService.person.MaleOrFemale,
                      this.personService.person.HMO,
                      this.personService.children
                    )
                  )
                  .subscribe(
                    (succ) => {
                      this.personService.children.map;
                      console.log('succ', succ);
                      alert('ברוך הבא');
                      this.data.push(
                        new Person(
                          0,
                          this.personService.person.FirstName,
                      this.personService.person.LastName,
                      this.personService.person.TZ,
                      new Date(),
                      this.personService.person.MaleOrFemale,
                      this.personService.person.HMO,
                      this.personService.children
                        )
                      );
                      this.personService.children.map((item) =>
                        this.data.push(
                          new Child(
                            item.Id,
                            item.Name,
                            item.TZ,
                            item.DateOfBirth
                          )
                        )
                      );
                      this.exportexcel(
                        this.data,
                        this.personService.person.FirstName
                      );
                      this.personService.children=[]
                      this.data = [];
                      this.resetForm(this.form);
                    },
                    (err) => {
                      console.log('err', err);
                    }
                  );
              } else {
                console.log('ssssssssss', succ);
                //   this.userService.PostParent(new User(0,this.user.ParentId,this.user.FirstName,this.user.LastName,this.children,this.user.GenderType,this.user.HMOType,new Date()))
                alert('אתה כבר רשום למערכת');
                this.resetForm(this.form);
              }
            },
            (err) => {
              console.log('err', err);
            }
          );
      }
    }
  }
  saveChildren() {
    if (
      this.checkCorrectDate(
        this.personService.child.DateOfBirth,
        this.personService.person.DateOfBirth
      ) === true
    ) {
      console.log('child', this.personService.child);
      this.personService.children.push(
        new Child(
          this.personService.child.Id,
          this.personService.child.Name,
          this.personService.child.TZ,
          this.personService.child.DateOfBirth
        )
      );
      // this.childServise.PostChild(this.child).subscribe(succ=>{alert("succ")},err=>{"err"})
      console.log('children', this.personService.children);
    }
  }
  checkCorrectDate(d1: any, d2: any) {
    if (d1 > d2) {
      alert('תאריך שגוי');
      return false;
    }
    return true;
  }
  exportexcel(json: any[], fileName: string): void {
    /* table id is passed over here */
    let element = document.getElementById('excel-table');
    const ws: XLSX.WorkSheet = XLSX.utils.json_to_sheet(json);

    /* generate workbook and add the worksheet */
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

    /* save to file */
    XLSX.writeFile(wb, fileName + '.xlsx');
  }
}
