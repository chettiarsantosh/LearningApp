import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Ng Client';
  weathers: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http.get("https://localhost:44355/WeatherForecast").subscribe(response => {
      this.weathers = response;
    },error => {
      console.log(error);
    }
    )
  }
}
