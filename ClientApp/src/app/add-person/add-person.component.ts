import { Component, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { RouterLink } from "@angular/router";

const _httpOptions = {
    headers : new HttpHeaders({
        'Content-Type' : 'application/json'
    })
};

@Component({
    selector: "add-person",
    templateUrl: "./add-person.component.html"
})

export class AddPersonComponent
{
    _http: HttpClient;
    _baseUrl: string;
    

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._http=http;
        this._baseUrl=baseUrl;
      }
    
    public person:PersonForm = {
        personId: 0,
        displayName: 'Dylan A Brigham',
        firstName: 'Dylan',
        lastName: 'Brigham'
    };

    public savePerson(): void {
        console.log("Logging.. " + this.person.displayName + " " + this.person.firstName + " " + this.person.lastName);
        this._http.post<PersonForm>(this._baseUrl+'api/Persons/Person', JSON.stringify(this.person), _httpOptions).subscribe(person=>this.person);
    }
}


interface PersonForm {
    personId: number;
    displayName: string;
    firstName: string;
    lastName: string;
  }