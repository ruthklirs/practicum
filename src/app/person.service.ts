
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import User from 'src/models/Person';
import { BehaviorSubject, Subject } from 'rxjs';
import Child from 'src/models/Child';
@Injectable({
  providedIn: 'root'
})
export class UserService {
formData:User

child:Child=new Child(0,"","",new Date())
user:User=new User(0,"","","",new Date(), 0,"",[])
children:Child[]=[]

  constructor(public http:HttpClient) { }
  GetParents():Observable<User[]>{
    return this.http.get<User[]>("https://localhost:44395/api/Parents")
  }
  GetParent(id:string):Observable<User>{
   return this.http.get<User>(`https://localhost:44395/api/Parents/${id}`)
 }

 PostParent(user: User){
   return this.http.post("https://localhost:44395/api/Parents",user)
 }
 DeleteParent(id:string){
   return this.http.delete(`https://localhost:44395/api/Parents/${id}`)
 }


}
