import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  // public forecasts: WeatherForecast[];
    public person: PersonData;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<PersonData>(baseUrl + 'api/Persons/PersonGet').subscribe(result => {
      this.person = result;
      }, error => console.error(error));
  }
}

// interface WeatherForecast {
//   dateFormatted: string;
//   temperatureC: number;
//   temperatureF: number;
//   summary: string;
// }

interface PersonData {
  personId: number;
  displayName: string;
  firstName: string;
  lastName: string;
}
