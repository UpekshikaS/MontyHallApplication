import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: false,
})
export class AppComponent {
  numberOfGames = 1000;
  switchChoice = true;
  result: any;

  constructor(private http: HttpClient) { }

  runSimulation() {
    this.http.get(`https://localhost:7078/api/MontyHall/simulate?numberOfGames=${this.numberOfGames}&switchChoice=${this.switchChoice}`)
    
      .subscribe(
        (res: any) => {
          this.result = res,
          console.log("API CALL RESPONSE ===> ", JSON.stringify(res))
        },
        (err: HttpErrorResponse) => {
          console.error('Error occurred:', err);
        }
      );
  }
}

