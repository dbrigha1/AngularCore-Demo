import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent implements OnInit {
  
    public persons: PersonData[];
    public readonly _http: HttpClient;
    public readonly _baseUrl:string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._http = http;
    this._baseUrl=baseUrl;
  }

  ngOnInit(): void {
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
    this._http.delete<PersonData[]>(this._baseUrl+'api/Persons/PersonDeleteAll').subscribe(result=> {this.persons = result;});
  };

}

interface PersonData {
  personId: number;
  displayName: string;
  firstName: string;
  lastName: string;
}
