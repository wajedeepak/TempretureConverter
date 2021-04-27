import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-temp-converter',
  templateUrl: './temp-converter.component.html'
})
export class TempConverterComponent {
  public tempValues: ITempretureValues;
  private _http: HttpClient;
  private _baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.tempValues = <ITempretureValues> {
              temperatureK: 0,
              temperatureC: 0,
              temperatureF:0
            }
    this._http = http;
    this._baseUrl = baseUrl;
  }

  public onValueChange(type: number) {
    let value = this.getValue(type);
    this._http.get<ITempretureValues>(this._baseUrl + 'api/TempConverter/ConvertUnit?type=' + type +'&value=' + value).subscribe(result => {
      this.tempValues = result;
    }, error => console.error(error));
  }

  public getValue(type: number) : number{
    switch (type) {
      case 1:
        return this.tempValues.temperatureC;
      case 2:
        return this.tempValues.temperatureF;
      case 3:
        return this.tempValues.temperatureK;
      default: {
        return 0;
      }
    };
  }
}

interface ITempretureValues {
  temperatureK: number;
  temperatureC: number;
  temperatureF: number;
}
