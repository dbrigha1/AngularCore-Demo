import { Component, Inject } from '@angular/core';
import { HttpClient, HttpSentEvent } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
    public persons: PersonData[];
    public readonly _http: HttpClient;
    public readonly _baseUrl:string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._http = http;
    this._baseUrl=baseUrl;
    this.GetAll();
  }

  public GetAll() : void
  {
    this._http.get<PersonData[]>(this._baseUrl + 'api/Persons/Person').subscribe(result => {
    this.persons = result;
    }, error => console.error(error));   
  }

  public DeleteAll() :void
  {
    console.log("Deleting Persons...");
    this._http.delete(this._baseUrl+'api/Persons/PersonDeleteAll').subscribe(persons=>this.persons);
    this.persons = null;
  };

}

interface PersonData {
  personId: number;
  displayName: string;
  firstName: string;
  lastName: string;
}
