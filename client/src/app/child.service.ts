
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Child from 'src/models/Child';


@Injectable({
  providedIn: 'root'
})
export class ChildService {

  constructor(public http:HttpClient) { }
  GetChildren():Observable<Child[]>{
    return this.http.get<Child[]>("https://localhost:44395/api/Children")
  }
  GetChild(id:string):Observable<Child>{
   return this.http.get<Child>(`https://localhost:44395/api/Children/${id}`)
 }

 PostChild(child: Child){
   return this.http.post("https://localhost:44395/api/Children",child)
 }
 DeleteChild(id:string){
   return this.http.delete(`https://localhost:44395/api/Children/${id}`)
 }
}
